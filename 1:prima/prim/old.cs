
public class Old 
{
    private readonly Repository _repository;
    private readonly Translator _translator;

    public Old(Repository repo, Translator translator) 
    {
        _repository = repo;
        _translator = translator;
    }

    public string GetPost(string id) 
    {
        var post = _repository.GetPost(id);
        return _translator.Translate(post);
    }
}

