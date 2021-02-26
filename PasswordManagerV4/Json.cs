using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManagerV3
{
    class Json
    {
        string json { get; set; }
        List<Password> passwordList { get; set; }

        // Password list naar string in json formaat
        static public string PasswordListToStringAsJson(List<Password> passwordList)
        {
            //Update json data string
            string json = JsonConvert.SerializeObject(passwordList, Formatting.Indented);
            return json;
            //System.IO.File.WriteAllText(path, json);
        }

        // Maakt van een json file een list
        static public List<Password> JsonToPasswordList(string path)
        {
            List<Password> passwordList;

            // Json openen list van maken Object toevoegen aan list, en weer json string van maken en schrijven naar file.
            // Read existing json data
            string json = System.IO.File.ReadAllText(path);

            // Als het een juist Json formaat is word hij geopend en worden de values als list gemaakt
            // De-serialize to list
            
            if (json.StartsWith("[")) 
            { 
                return passwordList = JsonConvert.DeserializeObject<List<Password>>(json);
            }
            // Als file geen juiste Json is lees het als lege json
            else 
            { 
                return passwordList = JsonConvert.DeserializeObject<List<Password>>("[]"); 
            }
        }

        //Password toevoegen aan list
        static public List<Password> AddPasswordToList(List<Password> passwordList, string path, string website, string email , string generatedPassword)
        {
            // Check if text == valid json
            // Password toevoegen aan list
            // Als dit niet gebeurt was de passwordList null en kon er niks toegevoegd worden
            if (passwordList == null) 
            {
                passwordList = JsonConvert.DeserializeObject<List<Password>>("[]"); 
            }

            // Objecten toevoegen aan list
            Password password = new Password(website, email, generatedPassword);
            passwordList.Add(password);

            return passwordList;
        }

        // account list naar string in json formaat
        static public string AccountListToStringAsJson(List<Account> accountList)
        {
            //Update json data string
            string json = JsonConvert.SerializeObject(accountList, Formatting.Indented);
            return json;
            //System.IO.File.WriteAllText(path, json);
        }

        // Maakt van een json file een list
        static public List<Account> JsonToAccountList(string path)
        {
            List<Account> accountList;

            // Json openen list van maken Object toevoegen aan list, en weer json string van maken en schrijven naar file.
            // Read existing json data
            string json = System.IO.File.ReadAllText(path);

            // Als het een juist Json formaat is word hij geopend en worden de values als list gemaakt
            // De-serialize to list

            if (json.StartsWith("["))
            {
                return accountList = JsonConvert.DeserializeObject<List<Account>>(json);
            }
            // Als file geen juiste Json is lees het als lege json
            else
            {
                return accountList = JsonConvert.DeserializeObject<List<Account>>("[]");
            }
        }

        static public List<Account> AddAccountToList(List<Account> accountList, string username, string password)
        {
            // Check if text == valid json
            // Password toevoegen aan list
            // Als dit niet gebeurt was de passwordList null en kon er niks toegevoegd worden
            if (accountList == null)
            {
                accountList = JsonConvert.DeserializeObject<List<Account>>("[]");
            }

            // Objecten toevoegen aan list
            Account account = new Account(username,password);
            accountList.Add(account);

            return accountList;
        }
    }
}
