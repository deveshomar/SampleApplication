using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication.InterfaceWithDI
{

    // SOILD PRINCPAL
    // S - Single Responsibility Principle
    // O - Open/Closed Principle
    // L - Liskov Substitution Principle
    // I - Interface Segregation Principle
    // D - Dependency Inversion Principle   
    public interface  IUser: IreadOnlyUser
    {
      
        void Write();
                
    }
    public interface IreadOnlyUser 
    {
        void Read();
    }
    public interface IUserDeletePermission : IUser
    {
        void Delete();
    }

    public class AdminUser : IUser
    {
        

        void IreadOnlyUser.Read()
        {
            throw new NotImplementedException();
        }

        void IUser.Write()
        {
            Console.WriteLine("Write ");
        }
    }

    public class SuperAdmin : IUserDeletePermission
    {
        void IUserDeletePermission.Delete()
        {
            throw new NotImplementedException();
        }

       

        void IreadOnlyUser.Read()
        {
            throw new NotImplementedException();
        }

        void IUser.Write()
        {
            Console.WriteLine("SuperAdmin Write ");
        }
    }   

    public class ReadonlyUser : IreadOnlyUser
    {
        void IreadOnlyUser.Read()
        {
            Console.WriteLine("Read only user Read");
        }

       
    }

    internal class ClassTest
    {
    }
}
