﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Firebase.Auth;
using Firebase.Auth.Providers;
using Firebase.Database;
using Firebase.Database.Query;

namespace FrequenceGenerator
{
    public class FirebaseUser
    {
        //Connect app with firebase using API Url
        public static FirebaseClient firebase = new FirebaseClient("https://frequencegenerator-default-rtdb.firebaseio.com/");
        
        //Read all
        public static async Task<List<Users>> GetAllUser()
        {
            try    
            {    
                var userlist = (await firebase    
                    .Child("Users")    
                    .OnceAsync<Users>()).Select(item =>    
                    new Users    
                    {    
                        Email = item.Object.Email,    
                        Password = item.Object.Password    
                    }).ToList();    
                return userlist;    
            }    
            catch(Exception e)    
            {    
                Debug.WriteLine($"Error:{e}");    
                return null;    
            } 
        }
        
        //Read     
        public static async Task<Users> GetUser(string email)    
        {    
            try
            {
                var allUsers = await GetAllUser();    
                await firebase    
                .Child("Users")    
                .OnceAsync<Users>();    
                return allUsers.Where(a => a.Email == email).FirstOrDefault();    
            }    
            catch(Exception e)    
            {    
                Debug.WriteLine($"Error:{e}");    
                return null;    
            }    
        }    
    
        //Insert a user    
        public static async Task<bool> AddUser(string email,string password)    
        {    
            try    
            {
                await firebase    
                .Child("Users")    
                .PostAsync(new Users() { Email = email, Password = password });    
                return true;    
            }    
            catch(Exception e)    
            {    
                Debug.WriteLine($"Error:{e}");    
                return false;    
            }    
        }    
    
        //Update     
        public static async Task<bool> UpdateUser(string email,string password)    
        {    
            try    
            {    
    
    
                var toUpdateUser = (await firebase    
                .Child("Users")    
                .OnceAsync<Users>()).Where(a => a.Object.Email == email).FirstOrDefault();    
                await firebase    
                .Child("Users")    
                .Child(toUpdateUser.Key)    
                .PutAsync(new Users() { Email = email, Password = password });    
                return true;    
            }    
            catch(Exception e)    
            {    
                Debug.WriteLine($"Error:{e}");    
                return false;    
            }    
        }    
    
        //Delete User    
        public static async Task<bool> DeleteUser(string email)    
        {    
            try    
            {
                var toDeletePerson = (await firebase    
                .Child("Users")    
                .OnceAsync<Users>()).Where(a => a.Object.Email == email).FirstOrDefault();    
                await firebase.Child("Users").Child(toDeletePerson.Key).DeleteAsync();    
                return true;    
            }    
            catch(Exception e)    
            {    
                Debug.WriteLine($"Error:{e}");    
                return false;    
            }    
        }
    }
}