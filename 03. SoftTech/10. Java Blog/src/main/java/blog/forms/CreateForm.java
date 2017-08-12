package blog.forms;

import javax.validation.constraints.NotNull;
import javax.validation.constraints.Size;

public class CreateForm {
    @Size(min=2, max=50, message = "Title size should be in the range [2...50]")
    private String title;

    @Size(min=1, max=4096, message = "Content size should be in the range [1...4096]")
    private String body;

    public String getTitle() {
        return title;
    }

    public void setTitle(String title) {
        this.title = title;
    }

    public String getBody() {
        return body;
    }

    public void setBody(String body) {
        this.body = body;
    }
}
