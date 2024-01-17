using moshaver.Models;

namespace moshaver
{
    public class UserRepository
    {
         public Myresult AddUser(Users users)
        {
            Myresult myresult = new() { ErroCode = 0, ErroStr = "", IsSuccessfull = true };  
            try
            {

        
            using var Moshaverdc = new MoshaverDbContext();
            {
              

                Moshaverdc.Users.Add(users);
                Moshaverdc.SaveChanges();
            }
            }
            catch (Exception ex1 )
            {
                myresult.ErroCode = 100;
                myresult.IsSuccessfull = false;
                myresult.ErroStr = ex1.Message;
                return myresult;    


            }
            return new Myresult() {  ErroCode=0, ErroStr="",IsSuccessfull=true};
        }
    }
    

}
