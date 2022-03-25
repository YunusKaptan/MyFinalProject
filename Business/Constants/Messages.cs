using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Entities.Concrete;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Product added";
        public static string ProductNameInvalid = "Product name invalid";
        public static string MaintenanceTime = "System in maintenance";
        public static string ProductsListed = "Products listed";
        public static string ProductCountOfCategoryError = "There can be a maximum of 10 products in a category.";
        public static string ProductUpdated = "Product updated";
        public static string ProductNameAlreadyExists = "Product name already exists";
        public static string CategoryLimitExceeded = "Category limit exceeded";
        public static string AuthorizationDenied = " Authorization denied";
        public static string UserRegistered = "User registered";
        public static string UserNotFound = "User not found";
        public static string PasswordError = "Password error";
        public static string SuccessfullyLogin = "Successfully login";
        public static string UserAlreadyExists = "User already exists";
        public static string AccessTokenCreated = "AccessToken created ";
    }
}
