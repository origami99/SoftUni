package blog.controllers;

import blog.models.Post;
import blog.models.User;
import blog.services.NotificationService;
import blog.services.PostService;
import blog.services.UserService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestMapping;

import java.util.List;

@Controller
public class UsersController {
    @Autowired
    private UserService userService;

    @Autowired
    private NotificationService notifyService;

    @RequestMapping("users/index")
    public String listUsers(Model model){
        List<User> allUsers = userService.findAll();
        if(allUsers == null){
            notifyService.addErrorMessage("Cannot find users");
            return "redirect:/";
        }
            model.addAttribute("allUsers", allUsers);
        return "users/index";
    }

}
