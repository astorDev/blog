var postsService = new Repository();
var translationService = new Translator();

var controller = new New(postsService, translationService);
var post = controller.GetPost("1");

Console.WriteLine(post);

public class Translator {
    public string Translate(string text) {
        return text;
    }
}

public class Repository {
    public string GetPost(string id) {
        return "Post " + id;
    }
}

// public class OldPostController 
// {
//     private readonly PostsService _postsService;
//     private readonly TranslationService _translationService;

//     public OldPostController(PostsService postsService, TranslationService translationService) 
//     {
//         _postsService = postsService;
//         _translationService = translationService;
//     }

//     public string GetPost(string id) 
//     {
//         var post = _postsService.GetPost(id);
//         return _translationService.Translate(post);
//     }
// }
