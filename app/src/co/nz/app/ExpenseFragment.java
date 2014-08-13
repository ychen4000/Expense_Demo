package co.nz.app;


import android.os.Bundle;
import android.os.Handler;
import android.os.Message;
import android.support.v4.app.Fragment;
import android.support.v4.app.FragmentManager;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.View;
import android.view.View.OnClickListener;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.TextView;

public class ExpenseFragment extends Fragment{

	private View v;
	private Button AddAccount;
	private TextView[] Account = new TextView[10];
	
	private TextView[] Balance = new TextView[10];
	
	private int accountNo = 0;
	
	private AccountCreateDialogFragment MyDialogFragment;
    private boolean i = false;
    private Thread thread;
	
	
	@Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
    }

    /**
     * The Fragment's UI is just a simple text view showing its name
    */
    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
            Bundle savedInstanceState) {
         v = inflater.inflate(R.layout.fragment_expense, container, false);
        View tv = v.findViewById(R.id.textView);
        ((TextView)tv).setText("This is expense(Maximum 3 account for testing");
        
        
        AddAccount = (Button)v.findViewById(R.id.button_add_account);
        Account[0] = (TextView)v.findViewById(R.id.textView_account1);
        Balance[0] = (TextView)v.findViewById(R.id.textView_balance1);
        Account[1] = (TextView)v.findViewById(R.id.TextView_account2);
        Balance[1] = (TextView)v.findViewById(R.id.textView_balance2);
        Account[2] = (TextView)v.findViewById(R.id.TextView_account3);
        Balance[2] = (TextView)v.findViewById(R.id.textView_balance3);
        final Handler myHandler = new Handler( )
        {
        	@Override
        	public void handleMessage(Message msg)
        	{   int i = 0;
        		if (msg.what == 0x1233)
        		{
        			accountNo = MyDialogFragment.accountNo - 1;
        			
        			Log.w("JinLog", accountNo+"");
        			Log.w("JinLog", i+"");
        			
        		
        			Account[accountNo].setText(MyDialogFragment.myAccountList[accountNo].GetAccountName());
				    Balance[accountNo].setText( MyDialogFragment.myAccountList[accountNo].GetBalance().toString());
        			i++;
        			
        		
        				if (accountNo == 2)
        				AddAccount.setClickable(false);
        			
        		}
        		
        		
        	}
        	
        	
        }; 
        
        
        MyDialogFragment = new AccountCreateDialogFragment();
        AddAccount.setOnClickListener(
        		
        		   new OnClickListener ()
        		   {
        			   

					@Override
					public void onClick(View v) 
					  {
						
						 FragmentManager fm = getActivity().getSupportFragmentManager();
						
						 MyDialogFragment.show(fm, "Dialog");
						 
						
						 Runnable run = new Runnable() {

								@Override
								public void run() 
								{
									while (true)
									{
										
									while (MyDialogFragment.ifDone == true) 
									  {
										System.out.println("aaaaaa");
										myHandler.sendEmptyMessage(0x1233);
										MyDialogFragment.ifDone = false;
										//thread.destroy();
									  }
								    }
								}
							};

							thread = new Thread(run);
							thread.start();
						//Account1.setText(MyDialogFragment.myAccountList[0].GetAccountName());
						//Balance1.setText( MyDialogFragment.myAccountList[0].GetBalance().toString());
						// http://blog.csdn.net/penglijiang/article/details/7730074
						// http://blog.csdn.net/piglovesula/article/details/10460161
					  }
        			   
        			   
        			   
        		   }
        		
        		);
        
        
       
        
        
        return v;
    }
    
 
    
    
    
   
}



