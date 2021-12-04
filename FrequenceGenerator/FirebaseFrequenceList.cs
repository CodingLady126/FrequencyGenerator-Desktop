using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Firebase.Database;
using Firebase.Database.Query;

namespace FrequenceGenerator
{
    public class FirebaseFrequenceList
    {
        //Connect app by using Firebase Using API url
        public static FirebaseClient firebase =
            new FirebaseClient("https://frequencegenerator-default-rtdb.firebaseio.com/");
        
        //Read all Frequence List
        public static async Task<List<FrequenceList>> GetFrequencies()
        {
            try
            {
                var freqList = (await firebase    
                    .Child("FrequenceList")    
                    .OnceAsync<FrequenceList>()).Select(item =>    
                    new FrequenceList()    
                    {    
                        FrequenceName = item.Object.FrequenceName,    
                        ToneHz = item.Object.ToneHz    
                    }).ToList();    
                return freqList; 
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        
        //Read special Frequence 
        public static async Task<FrequenceList> GetFrequence(string freqName)
        {
            try
            {
                var allFrequencies = await GetFrequencies();    
                await firebase    
                    .Child("FrequenceList")    
                    .OnceAsync<Users>();    
                return allFrequencies.Where(a => a.FrequenceName == freqName).FirstOrDefault();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        
        //Insert a Frequence    
        public static async Task<bool> AddFrequence(string freqName,string toneHz)    
        {    
            try    
            {
                await firebase    
                    .Child("FrequenceList")    
                    .PostAsync(new FrequenceList() { FrequenceName = freqName, ToneHz = toneHz });    
                return true;    
            }    
            catch(Exception e)    
            {    
                Debug.WriteLine($"Error:{e}");    
                return false;    
            }    
        }    
    
        //Update     
        public static async Task<bool> UpdateFrequence(string freqName,string toneHz)    
        {    
            try    
            {
                var toUpdateFrequence = (await firebase    
                    .Child("FrequenceList")    
                    .OnceAsync<FrequenceList>()).Where(a => a.Object.FrequenceName == freqName).FirstOrDefault();    
                await firebase    
                    .Child("Users")    
                    .Child(toUpdateFrequence.Key)    
                    .PutAsync(new FrequenceList() { FrequenceName = freqName, ToneHz = toneHz });    
                return true;    
            }    
            catch(Exception e)    
            {    
                Debug.WriteLine($"Error:{e}");    
                return false;    
            }    
        }    
    
        //Delete User    
        public static async Task<bool> DeleteFrequence(string freqName)    
        {    
            try    
            {
                var toDeleteFrequence = (await firebase    
                    .Child("FrequenceList")    
                    .OnceAsync<FrequenceList>()).Where(a => a.Object.FrequenceName == freqName).FirstOrDefault();    
                await firebase.Child("FrequenceList").Child(toDeleteFrequence.Key).DeleteAsync();    
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