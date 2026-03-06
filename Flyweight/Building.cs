using Flyweight;

class Building
{

    #region Intrinsic State
    public RealStateDeveloper RealStateDeveloper { get; set; }
        
    #endregion 
    
    #region Extrinsic State
    public string Address { get; set; }
    public int DepartmentsCount { get; set; }

    #endregion
     
    public Building(RealStateDeveloper realState, string adress, int departmentsCount)
    {
        Address = adress;
        RealStateDeveloper = realState ;
        DepartmentsCount = departmentsCount;
    }
}