using System;

namespace CinemaFunctions
{
    public class TicketPriceController
    {

        public decimal Adult_Before_5(int pr_quantity, string pr_person, string pr_day, decimal pr_time) // Naming of the function and which constraints/variables are going to be involved.
        {
            decimal ticket_price = 14.50M; // Ticket price is equal to $14.50
            decimal result = -1; // The result if the entered variables are not within the parameters set for this function.

            if (pr_person.ToLower() != "adult" || pr_day.ToLower() == "tuesday" || pr_quantity < 1 || pr_time >= 1700) /* Translates to: If the person in not adult or it is Tuesday, or, quantity of tickets
                                                                                                                        * is less than 1, or, the time is greater than or equal to 5pm. */
            {
                return result; // If any of the variables do not pass, return decimal result = -1
            }
            else
            {
                result = (ticket_price * pr_quantity); // if all the variables pass, return a result of ticket price * ticket quantity.
                return result;
            }
        }


        public decimal Adult_After_5(int pr_quantity, string pr_person, string pr_day, decimal pr_time) // Naming of the function and which constraints/variables are going to be involved.
        {
            decimal ticket_price = 17.50M;  // Ticket price is equal to $17.50
            decimal result = -1; // The result if the entered variables are not within the parameters set for this function.

            if (pr_person.ToLower() != "adult" || pr_day.ToLower() == "tuesday" || pr_quantity < 1 || pr_time < 1700) /* Translates to: If the person is not adult, or it is Tuesday, or, quantity of tickets
                                                                                                                       * is less than 1, or, the time is less than 5pm. */
            {
                return result; // If any of the variables do not pass, return decimal result = -1
            }
            else
            {
                result = (ticket_price * pr_quantity); // if all the variables pass, return a result of ticket price * ticket quantity.
                return result;
            }
        }


        public decimal Adult_Tuesday(int pr_quantity, string pr_person, string pr_day) // Naming of the function and which constraints/variables are going to be involved.
        {
            decimal ticket_price = 13.00M; // Ticket price is equal to $13.00
            decimal result = -1; // The result if the entered variables are not within the parameters set for this function.

            if (pr_person.ToLower() == "adult" && pr_day.ToLower() == "tuesday" && pr_quantity >= 1) /* Translates to: If the person is adult, and it is a Tuesday, and the ticket quantity is greater
                                                                                                      * than or equal to 1. */
            {
                result = (ticket_price * pr_quantity); // if all the variables pass, return a result of ticket price * ticket quantity.
                return result;
            }
            return result; // If any of the variables do not pass, return decimal result = -1
        }


        public decimal Child_Under_16(int pr_quantity, string pr_person) // Naming of the function and which constraints/variables are going to be involved.
        {
            decimal ticket_price = 12.00M; // Ticket price is equal to $12.00
            decimal result = -1; // The result if the entered variables are not within the parameters set for this function.

            if (pr_person.ToLower() == "child" && pr_quantity >= 1) // Translates to: If the person is a child, and the ticket quantity is equal to or greater than 1.
            {
                result = (ticket_price * pr_quantity); // if all the variables pass, return a result of ticket price * ticket quantity.
                return result;
            }
            return result; // If any of the variables do not pass, return decimal result = -1
        }


        public decimal Senior(int pr_quantity, string pr_person) // Naming of the function and which constraints/variables are going to be involved.
        {
            decimal ticket_price = 12.50M; // Ticket price is equal to $12.50
            decimal result = -1; // The result if the entered variables are not within the parameters set for this function.

            if (pr_person.ToLower() == "senior" && pr_quantity >= 1) // Translates to: If the person is a senior, and the ticket quantity is equal to or greater than 1.
            {
                result = (ticket_price * pr_quantity); // if all the variables pass, return a result of ticket price * ticket quantity.
                return result;
            }
            return result; // If any of the variables do not pass, return decimal result = -1
        }


        public decimal Student(int pr_quantity, string pr_person) // Naming of the function and which constraints/variables are going to be involved.
        {
            decimal ticket_price = 14.00M; // Ticket price is equal to $14.00
            decimal result = -1; // The result if the entered variables are not within the parameters set for this function.

            if (pr_person.ToLower() == "student" && pr_quantity >= 1) // Translates to: If the person is a student, and the ticket quantity is equal to or greater than 1.
            {
                result = (ticket_price * pr_quantity); // if all the variables pass, return a result of ticket price * ticket quantity.
                return result;
            }
            return result; // If any of the variables do not pass, return decimal result = -1
        }


        public decimal Family_Pass(int pr_quantity_ticket, int pr_quantity_adult, int pr_quantity_child) // Naming of the function and which constraints/variables are going to be involved.
        {
            decimal ticket_price = 46.00M; // Ticket price is equal to $46.00
            decimal result = -1; // The result if the entered variables are not within the parameters set for this function.

            if (pr_quantity_ticket >= 1 && pr_quantity_adult == 2 && pr_quantity_child == 2 || /* Translates to: if the quantity of tickets is greater than or equal to 1, and the quantity of adults must
                                                                                                * equal 2, and the quantity of children must equal 2. */
                                                                                                
                pr_quantity_ticket >= 1 && pr_quantity_adult == 1 && pr_quantity_child == 3) /* Translates to: If the quantity of tickets is great than or equal to 1, and the quantity of adults must 
                                                                                              * equal 1, and the quantity of children must equal 3. */
                                                                                                          {
                result = (ticket_price * pr_quantity_ticket); // if all the variables pass, return a result of ticket price * ticket quantity.
                return result;
            }
            return result; // If any of the variables do not pass, return decimal result = -1
        }


        public decimal Chick_Flick_Thursday(int pr_quantity, string pr_person, string pr_day) // Naming of the function and which constraints/variables are going to be involved.
        {
            decimal ticket_price = 21.50M; // Ticket price is equal to $21.50
            decimal result = -1; // The result if the entered variables are not within the parameters set for this function.

            if (pr_person.ToLower() == "adult" && pr_day.ToLower() == "thursday" && pr_quantity >= 1) /* Translates to: If the person is an adult, and the day is Thursday, and the quantity
                                                                                                       * of tickets is greater than or equal to 1. */
            {
                result = (ticket_price * pr_quantity); // if all the variables pass, return a result of ticket price * ticket quantity.
                return result;
            }
            return result; // If any of the variables do not pass, return decimal result = -1
        }


        public decimal Kids_Careers(int pr_quantity, string pr_day, bool pr_holiday) // Naming of the function and which constraints/variables are going to be involved.
        {
            decimal ticket_price = 12.00M; // Ticket price is equal to $12.00
            decimal result = -1; // The result if the entered variables are not within the parameters set for this function.

            if (pr_quantity >= 1 && pr_day.ToLower() == "wednesday" && pr_holiday == false) /* Translates to: If the quantity of tickets is greater than or equal to 1, and it is a Wednesday, and
                                                                                             * it is not a public holiday. */
            {
                result = (ticket_price * pr_quantity); // if all the variables pass, return a result of ticket price * ticket quantity.
                return result;
            }
            return result; // If any of the variables do not pass, return decimal result = -1
        }







    }
}