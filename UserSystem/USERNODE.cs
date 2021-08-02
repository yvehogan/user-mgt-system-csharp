
namespace UserSystem
{
     /// <summary>
    /// Class that defines the node instance
    /// </summary>
    public class USERNODE<T>
    { 
        public T FirstName { get; set; }
        public T SecondName { get; set; }

        public T Email { get; set; }

        public T FavouriteFood { get; set; }

        public string Result { get; set; }


        public USERNODE(T value)
        {
            this.Value = value;
        }

        public USERNODE(T firstname, T secondname, T email, T favouritefood)
        {
            this.FirstName = firstname;
            this.SecondName = secondname;
            this.Email = email;
            this.FavouriteFood = favouritefood;

        }

        public USERNODE()
        {

        }

        // public T()
        // {
        //     Return "\t\t\t\t\t Name:" + FirstName + SecondName + "\t Email:" + Email + " \t Food:" + FavouriteFood ;
        // }

        public T Value { get; set; }

        public USERNODE<T> Next { get; set; }
        
    }
}