package co.nz.app.myobject;

import java.util.Date;

public class Transaction {
	
	
	private Date MyDate;
	private Double Amount;
	private Account From;
	private Account To;
	
	
	public Transaction (Account from, Account to, Double amount, Date mydate )
	
	 {
		this.From = from;
		this.To =to;
		this.Amount = amount;
		this.MyDate = mydate;
		
	 }
	
	public Date GetDate ( )
	  {
		return MyDate;		
		
	  }
	
	public Account GetAccountFrom ( )
	  {
		return From;		
		
	  }
	
	public Account GetAccountTo ( )
	  {
		return To;		
		
	  }
	
	public Double GetAmount ( )
      {
		return Amount;
		
		
	  }
	
	

}
