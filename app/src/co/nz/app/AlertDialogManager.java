package co.nz.app;

import android.app.AlertDialog;
import android.content.Context;
import android.content.DialogInterface;

public class AlertDialogManager {
	
	
	//context- application context
	//title - alert dialog title
	//message - alert message
	//status - success/failure (used to set icon), pass null if you dont want icon

	public void showAlertDialog(Context context, String title,String message){
		
		AlertDialog alertDialog=new AlertDialog.Builder(context).create();
		
		alertDialog.setTitle(title);
		
		//setting Dialog Message
		alertDialog.setMessage(message);
		
		
		//setting OK button
		alertDialog.setButton("OK", new DialogInterface.OnClickListener() {
			
			@Override
			public void onClick(DialogInterface dialog, int which) {
				
				
			}
		});
		
		//showing alert message
		alertDialog.show();
	}

}
