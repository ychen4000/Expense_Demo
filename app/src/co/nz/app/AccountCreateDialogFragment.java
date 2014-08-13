package co.nz.app;

import co.nz.app.modules.login.fragments.SignUpScreenFragment;
import co.nz.app.ExpenseFragment;
import co.nz.app.myobject.Account;
import android.app.AlertDialog;
import android.app.AlertDialog.Builder;
import android.app.Dialog;
import android.os.Bundle;
import android.support.v4.app.DialogFragment;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.view.View.OnClickListener;
import android.widget.Button;
import android.widget.EditText;



public class AccountCreateDialogFragment extends DialogFragment {
	
	public Account[] myAccountList = new Account[10];
	public boolean ifDone = false;

	public int accountNo = 0;
	
	public AccountCreateDialogFragment ( )
	{
		
		
	}
	
    @Override
	public View onCreateView(final LayoutInflater inflater, final ViewGroup container,  
            Bundle savedInstanceState)
	{
		
		getDialog().setTitle("Please enter your account");
		
		View view = inflater.inflate(R.layout.account_popupwindow, container);
		
		Button done = (Button)view.findViewById(R.id.button_done);
		final EditText AccountName = (EditText)view.findViewById(R.id.editText_accountname);
		final EditText balance = (EditText)view.findViewById(R.id.editText_balance);
		
		done.setOnClickListener(
		          new OnClickListener()
		          {
					@Override
					public void onClick(View v) {		
						AccountName.clearComposingText();
						
					if (accountNo < 3)
					{
						Account one = new Account();
						
						myAccountList[accountNo] = one;
						
						myAccountList[accountNo].SetAccountName(AccountName.getText().toString());
						myAccountList[accountNo].Balance(Double.valueOf(balance.getText().toString()));
					 
						accountNo++;
						ifDone = true;
					}
					
				else
					{
						
					
						
				    }
						
						getDialog().dismiss();
						
						/*
						View expenseView = inflater.inflate(R.layout.fragment_expense, container, false);
						TextView Account1 = (TextView)expenseView.findViewById(R.id.textView_account1);
					    TextView Balance1 = (TextView)expenseView.findViewById(R.id.textView_balance1);
					    
					    Account1.setText("account one");
					    Balance1.setText("1000");
					    */
						 
						
					}
		          }
		        );
     
		
		
	    
		
	
		
		
		return view;
       
	}

}
