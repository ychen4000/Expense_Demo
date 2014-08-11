package co.nz.app;

import android.os.Bundle;
import android.support.v4.app.Fragment;
import android.view.LayoutInflater;
import android.view.View;
import android.view.View.OnClickListener;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.TextView;

public class ExpenseFragment extends Fragment{

	private Button AddAccount;
	private TextView Account1;
	private TextView Account2;
	private TextView Account3;
	private TextView Account4;
	private TextView Account5;
	private TextView Balance1;
	private TextView Balance2;
	private TextView Balance3;

	
	
	
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
        View v = inflater.inflate(R.layout.fragment_expense, container, false);
        View tv = v.findViewById(R.id.textView);
        ((TextView)tv).setText("This is expense");
        
        
        AddAccount = (Button)v.findViewById(R.id.button_add_account);
        Account1 = (TextView)v.findViewById(R.id.textView_account1);
        Balance1 = (TextView)v.findViewById(R.id.textView_balance1);
        AddAccount.setOnClickListener(
        		
        		   new OnClickListener ()
        		   {
        			   

					@Override
					public void onClick(View v) 
					  {
						
						Account1.setText("Account One");
						Balance1.setText("Balance");
						
					  }
        			   
        			   
        			   
        		   }
        		
        		);
        
        
        return v;
    }
    
   
}
