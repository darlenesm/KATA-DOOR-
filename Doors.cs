using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace KATA_DOOR
{
    public class Door 
    {
        Door status;
 
        public bool isUnlocked;
        public bool isOpen;

        public Door(bool isOpen, bool isUnlocked)
        {
            this.isOpen = isOpen;
            this.isUnlocked = isUnlocked;
        }


        public bool OpenAndUnlocked(string key)
        {
            if (key == "Open and Unlock")
            {
                status = new Door(isOpen, isUnlocked);
                return true;
            }
            else
                return false;
        }

        public bool OpenAndLocked(string key)
        {
            if (key == "Open and Lock")
            {
                status = new Door (isOpen, !isUnlocked);
                return true;
            }
            else
                return false;
        }

        public bool CloseAndUnlocked(string key)
        {
            if (key == "Open and Lock")
            {
                status = new Door(!isOpen, isUnlocked);
                return true;
            }
            else
                return false;
        }

        public bool CloseAndLocked(string key) 
        {
            if (key == "Open and Lock")
            {
                status = new Door(!isOpen, !isUnlocked);
                return true;
            }
            else
                return false;
            
        }

        public bool IsOpen 
        {
            get
            {
                bool status = true;
                string st = status.ToString();
                Console.WriteLine("Status: Opened" + status);
                return status;
            }
        }
        public bool IsClosed
        {
            get
            {
                bool status = true;
                string st = status.ToString();
                Console.WriteLine("Status: Closed" + status);
                return status;
            }
        }
        public bool IsLocked
        {
            get
            {
                bool status = true;
                string st = status.ToString();
                Console.WriteLine("Status: Locked" + status);
                return status;
            }
        }
        public bool IsUnlocked
        {
            get
            {
                bool status = true;
                string st = status.ToString();
                Console.WriteLine("Status: Unlocked" + status);
                return status;
            }
        }


    }


}
