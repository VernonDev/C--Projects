using System;
using vehicleTracking;
internal class Program
{
    private static void Main(string[] args){

        new Program();
    }

     Vehicle[] vehicleArray = new Vehicle[50];
     int numVehicles = 0;


#region Properties
// The 'Make' property.
private string mMake = "";
public string Make
{
  get
  {  
  return mMake;
  }
  set
  {  
  mMake = value;
  
  }
}


// The 'Model' property.
private string mModel = "";
public string Model
{
  get
  {  
  return mModel;
  }
  set 
  {  
  mModel = value;
  
  }
}

// The 'eVehicleCondition'enumerator.
public enum eVehicleCondition
{  
  GOOD,  
  BAD,   
  UGLY
}; 
// The 'Condition'property.
private eVehicleCondition mCondition;
public eVehicleCondition Condition
{   
  get   
  {     
  return mCondition;   
  }   
  set   
  {       
  mCondition = value;
   
  }
}
// The 'Price' property.
private double mPrice = 0;
public double Price
{   
  get   
  {       
  return mPrice;   
  }   
  set  
  {      
  if (value > 0)       
  {
     mPrice = value;       
  }       
  else    
  {
     // If the value given is smaller than equal tozero.
           mPrice = 0;    
  }
   
  }
}

#endregion

#region Constructors
#endregion

#region Methods
#endregion



}




