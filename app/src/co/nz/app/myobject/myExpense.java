package co.nz.app.myobject;

import java.util.Date;

public class myExpense {
	
	private Double amount;
	private Date date;
	private Category category;
	private Account account;
	private Payee payee;
	
	
	public myExpense (Account account,Date date,Double amount,Category category,Payee payee )
	{
		this.account = account;
		this.date = date;
		this.amount = amount;
		this.category = category;
		this.payee = payee;
		
	}
	
	public Double getAmount( )
	{
		return amount;
		
	}
	
	public Date getDate ( )
	{
		return date;
		
	}
	
	public Category getCategory ( )
	{
		return category;
		
	}
	
	public Account getAccount( )
	{
		return account;
		
	}
	
	public Payee getPayee ( )
	{
		return payee;		
		
	}
	

}
