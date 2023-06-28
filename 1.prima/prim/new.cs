
public class New(Repository repository, Translator translator) 
{
    public string GetPost(string id) 
    {
        var post = repository.GetPost(id);
        return translator.Translate(post);
    }
}

