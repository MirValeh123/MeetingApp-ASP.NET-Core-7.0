namespace MeetingApp.Models
{
    public class Repository
    {
        
        private static List<UserInfo> _users = new();
        static Repository()
        {
            _users.Add(new UserInfo(){Id=1,Name="ALi",Email="abc@gmail.com",Phone="11111111",WillAttend=true});
            _users.Add(new UserInfo(){Id=2,Name="Mirvaleh",Email="mirvaleh@gmail.com",Phone="11111111",WillAttend=true});
            _users.Add(new UserInfo(){Id=3,Name="Qalib",Email="qalib@gmail.com",Phone="11111111",WillAttend=false});
        }
        public static List<UserInfo> Users 
        {
            get{
                return _users;
            }
             
        }
        public static void CreateUser(UserInfo user)
        {
            user.Id=Users.Count + 1 ;
            _users.Add(user);
        }

        public static UserInfo GetById(int id)
        {
            return _users.FirstOrDefault(user => user.Id == id);
        }
    }
}