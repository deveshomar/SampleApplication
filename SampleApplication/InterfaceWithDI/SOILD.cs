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
    public interface  IUser: IReadOnlyUser
    {
        void Write();
                
    }
    public interface IReadOnlyUser 
    {
        void Read();
    }
    public interface IUserDeletePermission : IUser
    {
        void Delete();
    }

    public class AdminUser : IUser
    {
        

        void IReadOnlyUser.Read()
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

        void IReadOnlyUser.Read()
        {
            throw new NotImplementedException();
        }

        void IUser.Write()
        {
            Console.WriteLine("SuperAdmin Write ");
        }
    }   

    public class ReadonlyUser : IReadOnlyUser
    {
        void IReadOnlyUser.Read()
        {
            Console.WriteLine("Read only user Read");
        }
       
    }

    internal class SOILD
    {
    }
}
