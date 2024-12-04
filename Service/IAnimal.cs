namespace MyAWebpp.Service
{
    public interface IAnimal
    {
        // Interface: Incomplete class.
        // we can not create object of an interface.
        // In inteface only we can declare the methods and properties.
        // All methods of interface need to be implemented in its's implemetation class.
        // we can achive 100 % absctraction by intface

        //Access modifier
        //1. public
        //2. private
        //3. default
        //4. protected

        int GetSpeed();
        void Run();
        string AnimalName { get; set; }
    }
}
