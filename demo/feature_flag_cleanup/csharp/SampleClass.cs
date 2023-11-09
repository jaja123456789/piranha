class Temp
{
    private int id;

    public int StudentId
    {
        get { return id; }
        set { id = value; }
    }
	
	public int TestMethod(int tmp)
	{
		
		if(Registry.GetBoolean("JIRA45_Enabled"))
		{
			something(1);
			return 1000;
		}
		something();
		something();
		return 200;

	}
	
	public int TestMethod1(int tmp)
	{
		
		var t = list.Where(x=>x.Active || (Registry.GetBoolean("JIRA45_Enabled") && !x.Active)).Select(x=> Registry.GetBoolean("JIRA45_Enabled")?x.var1:x.var2);
		
		if(!Registry.GetBoolean("JIRA45_Enabled"))
		{
			something();
			return 1000;
		}
		return 200;
	}
}