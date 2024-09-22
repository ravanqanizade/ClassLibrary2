using ClassLibrary1.DAL.Repositories.Context;

public class Project
{
    static void Main(string[] args)
    {
        Console.WriteLine("Start>>");
        UserDetailsRepository userDetailsRepository = new UserDetailsRepository();
        UserRepository userRepository = new UserRepository();
        PostRepository postRepository = new PostRepository();
        CommentRepository commentRepository = new CommentRepository();

        UserDetails user_INFO_1 = new UserDetails()
        {
            Name = "Ravan",
            Surname = "Qanizade",
            BirthDay = DateTime.Now,
            UserRole = UserDetails.Role.Admin
        };

        User user1 = new User()
        {
            UserDetailsId = 1
        };

        Post post1 = new Post()
        {
            Text = "Adnsu",
            Comment = "Salamm",
            UserId = 1,
        };

        Comment commentClass1 = new Comment()
        {
            Text = "Reply",
            comment = "duzune kesr",

        };

        userDetailsRepository.Add(user_INFO_1);
        userRepository.Add(user1);
        postRepository.Add(post1);
        commentRepository.Add(commentClass1);

        userDetailsRepository.SaveChanges();
        userRepository.SaveChanges();
        postRepository.SaveChanges();
        commentRepository.SaveChanges();
    }
}