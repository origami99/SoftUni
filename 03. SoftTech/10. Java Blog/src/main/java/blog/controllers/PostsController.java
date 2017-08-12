package blog.controllers;

import blog.forms.CreateForm;
import blog.forms.LoginForm;
import blog.models.Post;
import blog.models.User;
import blog.services.NotificationService;
import blog.services.PostService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.validation.BindingResult;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;

import javax.servlet.http.HttpSession;
import javax.validation.Valid;
import java.util.List;

@Controller
public class PostsController {
    @Autowired
    private PostService postService;

    @Autowired
    private NotificationService notifyService;

    @RequestMapping("/posts/view/{id}")
    public String view(@PathVariable("id") Long id, Model model) {
        Post post = postService.findById(id);
        if (post == null) {
            notifyService.addErrorMessage("Cannot find post #" + id);
            return "redirect:/";
        }
        model.addAttribute("post", post);
        return "posts/view";
    }

    @RequestMapping("posts/index")
    public String listPosts(Model model) {
        List<Post> allPosts = postService.findAll();
        if (allPosts == null) {
            notifyService.addErrorMessage("Cannot find posts");
            return "redirect:/";
        }
        model.addAttribute("allPosts", allPosts);
        return "posts/index";
    }

    @RequestMapping("/posts/create")
    public String createPage(CreateForm createForm) {
        return "posts/create";
    }


    @RequestMapping(value = "posts/create", method = RequestMethod.POST)
    public String createPost(@Valid CreateForm createForm, HttpSession httpSession, BindingResult bindingResult) {
        if (bindingResult.hasErrors()) {
            notifyService.addErrorMessage("Please fill the form correctly!");
            return "redirect:/";
        }
        postService.create(new Post(null, createForm.getTitle(), createForm.getBody(), new User(null, (String) httpSession.getAttribute("loggedUser"), null)));
        notifyService.addInfoMessage("Post created");
        return "redirect:/";
    }

    @RequestMapping("/posts/edit/{id}")
    public String edit(CreateForm createForm, @PathVariable("id") Long id, Model model) {
        Post post = postService.findById(id);
        if (post == null) {
            notifyService.addErrorMessage("Cannot find post #" + id);
            return "redirect:/";
        }
        model.addAttribute("postEdit", post);
        return "posts/edit";
    }

    @RequestMapping(value = "/posts/edit/{id}", method = RequestMethod.POST)
    public String postEdit(@PathVariable("id") Long id, @Valid CreateForm createForm, HttpSession httpSession, BindingResult bindingResult) {
        if (bindingResult.hasErrors()) {
            notifyService.addErrorMessage("Please fill the form correctly!");
            return "redirect:/";
        }
        postService.edit(new Post(id, createForm.getTitle(), createForm.getBody(), new User(null, (String) httpSession.getAttribute("loggedUser"), null)));
        notifyService.addInfoMessage("Post changed");
        return "redirect:/";
    }

    @RequestMapping("/posts/delete/{id}")
    public String delete(@PathVariable("id") Long id, Model model) {
        Post post = postService.findById(id);
        if (post == null) {
            notifyService.addErrorMessage("Cannot find post #" + id);
            return "redirect:/";
        }
        model.addAttribute("postDelete", post);
        return "posts/delete";
    }

    @RequestMapping(value = "/posts/delete/{id}", method = RequestMethod.POST)
    public String postDelete(@PathVariable("id") Long id) {
       postService.deleteById(id);
        notifyService.addInfoMessage("Post deleted");
        return "redirect:/";
    }
}
