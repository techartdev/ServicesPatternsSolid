using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ServicesPatternsSolid
{

    #region Single Responsibility Principle (SRP)

    // A class should have only one reason to change, focusing on a single functionality or responsibility.

    // Violates SRP
    public class InvoiceBad
    {
        // Invoice properties and methods

        public void SaveToDatabase() { /* implementation */ }
        public void ExportToPdf() { /* implementation */ }
    }

    // Refactored to follow SRP
    public class Invoice { /* Invoice properties and methods */ }
    public class InvoiceRepository { public void Save(Invoice invoice) { /* implementation */ } }
    public class InvoiceExporter { public void ExportToPdf(Invoice invoice) { /* implementation */ } }

    #endregion

    #region Open/Closed Principle (OCP)

    // Software entities (classes, modules, functions, etc.) should be open for extension, but closed for modification.

    // Violates OCP
    public class DiscountCalculatorBad
    {
        public decimal CalculateDiscount(Order order, string discountType)
        {
             /* implementation */
             return 0;
        }
    }

    // Refactored to follow OCP
    public interface IDiscountStrategy
    {
        decimal CalculateDiscount(Order order);
    }

    public class FixedDiscountStrategy : IDiscountStrategy
    {
         /* implementation */
         public decimal CalculateDiscount(Order order)
         {
             throw new NotImplementedException();
         }
    }

    public class PercentageDiscountStrategy : IDiscountStrategy
    {
         /* implementation */
         public decimal CalculateDiscount(Order order)
         {
             throw new NotImplementedException();
         }
    }

    public class DiscountCalculator
    {
        public decimal CalculateDiscount(Order order, IDiscountStrategy discountStrategy)
        {
            return discountStrategy.CalculateDiscount(order);
        }
    }

    #endregion


    #region Liskov Substitution Principle (LSP)

    // Objects in a program should be replaceable with instances of their subtypes without altering the correctness of that program.

    public abstract class BirdBad
    {
        public abstract void Fly();
    }

    public class PenguinBad : BirdBad
    {
        // Violates LSP because penguins cannot fly
        public override void Fly() { /* implementation */ }
    }

    // Refactored to follow LSP
    public abstract class Bird { }
    public interface IFlyable { void Fly(); }

    public class FlyingBird : Bird, IFlyable
    {
         /* implementation */
         public void Fly()
         {
             throw new NotImplementedException();
         }
    }
    public class Penguin : Bird { /* other penguin methods */ }


    #endregion

    #region Interface Segregation Principle (ISP)

    // Interfaces should be client-specific, avoiding forcing clients to depend on methods they do not use, promoting focused and minimal abstractions.

    // Violates ISP
    public interface IWorkerBad
    {
        void Work();
        void Eat();
    }

    // Refactored to follow ISP
    public interface IWorkable
    {
        void Work();
    }

    public interface IEatable
    {
        void Eat();
    }

    public class HumanWorker : IWorkable, IEatable
    {
        /* implementation */

        public void Work()
        {
            throw new NotImplementedException();
        }

        public void Eat()
        {
            throw new NotImplementedException();
        }
    }

    public class RobotWorker : IWorkable
    {
        /* implementation */

        public void Work()
        {
            throw new NotImplementedException();
        }
    }


    #endregion

    #region Dependency Inversion Principle (DIP)

    // High-level modules should not depend on low-level modules; both should depend on abstractions, resulting in a flexible and decoupled architecture.

    // Violates DIP
    public class EmailNotifierBad
    {
        private readonly SmtpClient _smtpClient;

        public EmailNotifierBad()
        {
            _smtpClient = new SmtpClient();
        }

        public void SendEmail(string recipient, string subject, string body) { /* implementation */ }
    }

    // Refactored to follow DIP
    public interface IEmailSender { void SendEmail(string recipient, string subject, string body); }

    public class EmailNotifier
    {
        private readonly IEmailSender _emailSender;

        public EmailNotifier(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        public void SendEmail(string recipient, string subject, string body)
        {
            _emailSender.SendEmail(recipient, subject, body);
        }
    }

    public class SmtpEmailSender : IEmailSender
    {
        public void SendEmail(string recipient, string subject, string body)
        {
            throw new NotImplementedException();
        }
    }

    public class ApiEmailSender : IEmailSender
    {
        public void SendEmail(string recipient, string subject, string body)
        {
            throw new NotImplementedException();
        }
    }

    #endregion
}
