package co.nz.app;

import android.content.Intent;
import android.os.Bundle;
import android.support.v4.app.Fragment;
import android.text.InputFilter;
import android.text.InputType;
import android.view.LayoutInflater;
import android.view.MotionEvent;
import android.view.View;
import android.view.View.OnClickListener;
import android.view.View.OnTouchListener;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;
import android.text.Spanned;
import android.text.method.PasswordTransformationMethod;


public class LockScreenFragment extends Fragment {
	
	 protected EditText pinCodeField1 = null;
	 protected EditText pinCodeField2 = null;
	 protected EditText pinCodeField3 = null;
	 protected EditText pinCodeField4 = null;
	 protected InputFilter[] filters = null;
	 protected TextView topMessage = null;
	 LockManager mLockManager;
	 AlertDialogManager alert;
	    
	

	
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
        View v = inflater.inflate(R.layout.fragment_lock_screen, container, false);
        
        topMessage=(TextView)v.findViewById(R.id.top_message);
        Bundle extras=getActivity().getIntent().getExtras();
        if(extras!=null){
        	String message=extras.getString("message");
        	if(message!=null){
        		topMessage.setText(message);
        	}
        }
        
        filters=new InputFilter[2];
        filters[0]=new InputFilter.LengthFilter(1);
        filters[1]=onlyNumber;
        
        //setup the pin fields row
        pinCodeField1=(EditText)v.findViewById(R.id.pincode_1);
        setupPinItem(pinCodeField1);
        
        pinCodeField2=(EditText)v.findViewById(R.id.pincode_2);
        setupPinItem(pinCodeField2);
        
        pinCodeField3=(EditText)v.findViewById(R.id.pincode_3);
        setupPinItem(pinCodeField3);
        
        pinCodeField4=(EditText)v.findViewById(R.id.pincode_4);
        setupPinItem(pinCodeField4);
        
        
        
        
        //set up the keyboard
        ((Button) v.findViewById(R.id.button0)).setOnClickListener(defaultButtonListener);
        ((Button) v.findViewById(R.id.button1)).setOnClickListener(defaultButtonListener);
        ((Button) v.findViewById(R.id.button2)).setOnClickListener(defaultButtonListener);
        ((Button) v.findViewById(R.id.button3)).setOnClickListener(defaultButtonListener);
        ((Button) v.findViewById(R.id.button4)).setOnClickListener(defaultButtonListener);
        ((Button) v.findViewById(R.id.button5)).setOnClickListener(defaultButtonListener);
        ((Button) v.findViewById(R.id.button6)).setOnClickListener(defaultButtonListener);
        ((Button) v.findViewById(R.id.button7)).setOnClickListener(defaultButtonListener);
        ((Button) v.findViewById(R.id.button8)).setOnClickListener(defaultButtonListener);
        ((Button) v.findViewById(R.id.button9)).setOnClickListener(defaultButtonListener);
        
        
        
        return v;
    }
    
    
    protected void setupPinItem(EditText item){
    	item.setInputType(InputType.TYPE_NULL);
    	item.setFilters(filters);
    	item.setOnTouchListener(otl);
    	item.setTransformationMethod(PasswordTransformationMethod.getInstance());
    }
    
    private OnTouchListener otl=new OnTouchListener(){
    	@Override
    	public boolean onTouch(View v,MotionEvent event){
    		if(v instanceof EditText){
    			((EditText) v).setText("");
    		}
    		return false;
    	}
    };
    
    
    
    private InputFilter onlyNumber=new InputFilter(){
    	
    	@Override
    	public CharSequence filter(CharSequence source,int start,int end,Spanned dest,int dstart,int dend){
    		if(source.length()>1){
    			return "";
    		}
    		if(source.length()==0){
    			//erase
    			return null;
    		}
    		
    		try{
    			int number=Integer.parseInt(source.toString());
    			if((number>=0) && (number<=9)){
    				return String.valueOf(number);
    			}else{
    				return "";
    			}
    		}catch(NumberFormatException e){
				return "";
			}
    	}
    };
    
    
    private OnClickListener defaultButtonListener=new OnClickListener(){
    	
    	@Override
    	public void onClick(View arg0){
    		int currentValue=-1;
    		int id = arg0.getId();
			if (id == R.id.button0) {
				currentValue = 0;
			} else if (id == R.id.button1) {
				currentValue = 1;
			} else if (id == R.id.button2) {
				currentValue = 2;
			} else if (id == R.id.button3) {
				currentValue = 3;
			} else if (id == R.id.button4) {
				currentValue = 4;
			} else if (id == R.id.button5) {
				currentValue = 5;
			} else if (id == R.id.button6) {
				currentValue = 6;
			} else if (id == R.id.button7) {
				currentValue = 7;
			} else if (id == R.id.button8) {
				currentValue = 8;
			} else if (id == R.id.button9) {
				currentValue = 9;
			} else {
			}
			
			//set the value and move the focus
			String currentValueString=String.valueOf(currentValue);
			
			if(pinCodeField1.isFocused()){
				pinCodeField1.setText(currentValueString);
				pinCodeField2.requestFocus();
				pinCodeField2.setText("");
			}else if(pinCodeField2.isFocused()){
				pinCodeField2.setText(currentValueString);
				pinCodeField3.requestFocus();
				pinCodeField3.setText("");
			}else if(pinCodeField3.isFocused()){
				pinCodeField3.setText(currentValueString);
				pinCodeField4.requestFocus();
				pinCodeField4.setText("");
			}else if(pinCodeField4.isFocused()){
				pinCodeField4.setText(currentValueString);
			}
			
			if(pinCodeField4.getText().toString().length() > 0 &&
                    pinCodeField3.getText().toString().length() > 0 &&
                    pinCodeField2.getText().toString().length() > 0 &&
                    pinCodeField1.getText().toString().length() > 0
                    ) {
                onPinLockInserted();
            }
    		
    	}
    	
    	
    	
    };
    
    
    protected void onPinLockInserted(){
    	String pin = pinCodeField1.getText().toString() + pinCodeField2.getText().toString() +
                pinCodeField3.getText().toString() + pinCodeField4.getText();
    	
    	mLockManager=new LockManager(getActivity());
    	boolean success=mLockManager.checkLogin(pin);
    	if(success){
    		Intent i=new Intent(getActivity().getApplicationContext(),MainActivity.class);
    		startActivity(i);
    	}else{
    		alert=new AlertDialogManager();
    		alert.showAlertDialog(getActivity(), "Login Failed", "PIN is wrong");
    		clear();
    	}
    	
    }
    
    private void clear(){
    	pinCodeField1.setText("");
    	pinCodeField2.setText("");
    	pinCodeField3.setText("");
    	pinCodeField4.setText("");
    	pinCodeField1.requestFocus();

    }
    
}



























































