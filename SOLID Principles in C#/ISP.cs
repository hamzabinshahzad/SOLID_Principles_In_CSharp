using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles_in_C_
{
    internal class ISP
    {

        // According to Interface Segregation Principle, We have split the interfaces so that we do not have to provide implementation to methods which are of no interest to us.
        // Also we have avoided Fatty Interfaces by following ISP
        public interface IStore
        {
            public void Fetch();
            public void Save();
            public void Update();
            public void Delete();
        }

        public interface ICache
        {
            public void AddKey();
            public void RemoveKey();
            public void EvictKey();
        }



        // As DBStore is only intersted in CRUD operatoins, so it only needs to implment those methods.
        public class DBStore : IStore
        {
            public void Fetch()
            {
                Console.WriteLine("DB fetched the required data.");
            }

            public void Save()
            {
                Console.WriteLine("DB added the provided data.");
            }

            public void Update()
            {
                Console.WriteLine("DB updated the required data.");
            }

            public void Delete()
            {
                Console.WriteLine("DB deleted the concerned data.");
            }
        }

        // Now the CacheStore is only used to deal with keys as it is temporary storage, so only those methods are of interest to it
        public class CacheStore : ICache
        {
            public void AddKey()
            {
                Console.WriteLine("Added the provided Key in cache.");
            }

            public void EvictKey()
            {
                Console.WriteLine("Banned the provided key from cache.");
            }

            public void RemoveKey()
            {
                Console.WriteLine("Removed the concerned Key in cache.");
            }
        }

        // Log Storage needs to log every call to every available method, so it will implement all the required interfaces.
        public class LogStorage : IStore, ICache
        {
            public void AddKey()
            {
                Console.WriteLine("[LOG]: A key was added.");
            }

            public void Delete()
            {
                Console.WriteLine("[LOG]: Concerned data was deleted.");
            }

            public void EvictKey()
            {
                Console.WriteLine("[LOG]: A key was banned.");
            }

            public void Fetch()
            {
                Console.WriteLine("[LOG]: Required data was fetched.");
            }

            public void RemoveKey()
            {
                Console.WriteLine("[LOG]: A key was removed.");
            }

            public void Save()
            {
                Console.WriteLine("[LOG]: Provided data was added.");
            }

            public void Update()
            {
                Console.WriteLine("[LOG]: Updated the required data.");
            }
        }


    }
}
