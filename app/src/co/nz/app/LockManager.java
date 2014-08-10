package co.nz.app;

import android.content.Context;
import android.content.SharedPreferences;
import android.content.SharedPreferences.Editor;

public class LockManager {
	
	//Shared Preferences
	SharedPreferences pref;
	
	//editor for sharedPreferences
	Editor editor;
	
	//Context
	Context _context;
	
	//Shared Pref Mode
	int PRIVATE_MODE=0;
	
	//Sharedpref file name
	private static final String PREF_NAME="Expense_Demo_User";
	
	//email(as well as userName)
	public static final String KEY_EMAIL="email";
	public static final String KEY_PIN="pin";
	
	public LockManager(Context context){
		this._context=context;
		pref=context.getSharedPreferences(PREF_NAME, PRIVATE_MODE);
		editor=pref.edit();
	}
	
	/*create login session*/
	public void createLoginSession(String email,String pin){
		
		//storing name in pref
		editor.putString(KEY_EMAIL, email);
		
		//storing pin in pref
		editor.putString(KEY_PIN,pin);
		
		//commit changes
		editor.commit();
	}
	
	//For Now, Just use a testing pin "1234"
	public boolean checkLogin(String pin){
		//String storedPin=pref.getString(KEY_PIN,"");
		if(pin.trim().length()>0){
			if(pin.equals("1234")){
				return true;
			}
		}
		return false;
	}
	
	

}




























