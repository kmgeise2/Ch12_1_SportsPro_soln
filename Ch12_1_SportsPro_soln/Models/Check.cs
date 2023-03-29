﻿using System.Linq;

namespace Ch12_1_SportsPro_soln.Models
{
    public static class Check
    {
        public static string EmailExists(SportsProContext context, string email)
        {
            string msg = "";
            if (!string.IsNullOrEmpty(email))
            {
                var customer = context.Customers.FirstOrDefault(
                    c => c.Email.ToLower() == email.ToLower());
                if (customer != null)
                    msg = "Email address already in use.";
            }
            return msg;
        }
    }
}