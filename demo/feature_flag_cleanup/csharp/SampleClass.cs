class Temp
{
    private int id;

    public int StudentId
    {
        get {
			return Registry.GetBoolean("JIRA45_Enabled") ? id: id1;
		}
        set { id = value; }
    }
	
	public int TestMethod(int tmp)
	{
		
		if(Registry.GetBoolean("JIRA45_Enabled"))
		{
			something(1);
			something(2);
			if(something())
			{
				somethingelse();
			}
			testing();
			return 1000;
		}
		something();
		something();
		return 200;

	}
	
	public int TestMethod2(int tmp)
	{
		
		var flag = Registry.GetBoolean("JIRA45_Enabled");
		flag = flag |= 1;
		if(flag){
			yay();
		}
		something();

	}
	
	public int TestMethod1(int tmp)
	{
		
		var t = list.Where(x=>x.Active || (Registry.GetBoolean("JIRA45_Enabled") && !x.Active)).Select(x=> Registry.GetBoolean("JIRA45_Enabled")?x.var1:x.var2);
		
		if(Registry.GetBoolean("JIRA45_Enabled"))
			something();

		return 200;
	}
}