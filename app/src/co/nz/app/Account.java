package co.nz.app;

public class Account {
	
	private String AccountName;
	
	private Double Balance;
	
	
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
	
	

}
