package co.nz.app.myobject;

public class Account {
	
	private String AccountName;
	
	private Double Balance = (double) 0;
	
	private String AccountDes;
	
	
	public Account ( )
	{
		
		
		
	}
	
	
	public void SetAccountName(String Account_Name)
	{
		this.AccountName = Account_Name;
		
	}
	
	public String GetAccountName ( )
	{
		
		
		return this.AccountName;
		
	}
	
	public void Balance (Double difference)
	{
		
		this.Balance = Balance + difference;
		
	}
	
	public Double GetBalance ( )
	{
		return this.Balance;		
		
	}
	
	public void setAccountDescription (String description )
	{
		
		this.AccountDes = description;
	}
	
	public String getAccountDes ( )
	{
		return AccountDes;
		
		
	}
	
	

}
