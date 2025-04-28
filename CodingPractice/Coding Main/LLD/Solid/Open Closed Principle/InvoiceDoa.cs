namespace Coding_Main.LLD.Solid.Open_Closed_Principle
{
    internal class InvoiceDoa
    {
        public void SaveFileToDb(string filename)
        {
            // Save to Database
        }

        // now in future if there comes a save senario where you want to save
        // to file not Db 

        //you will create another method 

        public void SaveToFile(string filename, object data) { 
        
        }

        // this voilates open/closed principle i.e we are modifying the class for extending new feature




        // this can also be the senerio of ocp

        public void Save(string type) {
            if(type == "Db")
            {
                //save to db
            }
            else if(type == "File")
            {
                // save to file
            }

        }

    }


    // Fix 


    public abstract class SaveData
    {
        public abstract void Save();
    }

    public class SaveToDb : SaveData
    {
        public override void Save()
        {
            //Save to db
        }
    }


    public class SaveToFile : SaveData
    {
        public override void Save()
        {
            // Save to file
        }
    }

}
