package co.nz.app;

import android.content.Context;
import android.database.sqlite.SQLiteDatabase;
import android.util.Log;



/**
* Provides access to a database of notes. Each note has a title, the note
* itself, a creation date and a modified data.
*/
public class dbHelper {
	
	private static final String TAG = "dbHelper";

    private static final String DATABASE_NAME = "expense_demo.db";
    
    SQLiteDatabase db;
    Context context;
    
	
	dbHelper(Context _context) {
    	context=_context;
    	db=context.openOrCreateDatabase(DATABASE_NAME, 0, null); 
    	Log.v(TAG,"db path="+db.getPath());
    }
	
	
	
	public void CreateTable_Account() {
    	try{
	        db.execSQL("CREATE TABLE account ("
	                + "_ID INTEGER PRIMARY KEY,"
	                + "PID integer,"
	                + "NAME TEXT"               
	                + ");");
	        Log.v("dbHelper","Create Table acctitem ok");
        }catch(Exception e){
        	Log.v("dbHelper","Create Table acctitem err,table exists.");
        }
    }
	
	
	 public void CreateTable_expense() {
	    	try{
		        db.execSQL("CREATE TABLE expense ("
		                + "_id INTEGER primary key autoincrement,"
		                +" acctitemid integer,"   
		                + "fee integer,"
		                + "userid integer,"
		                + "sdate TEXT,"
		                + "stime TEXT,"
		                + "desc TEXT"                
		                + ");");
		        
		        Log.v("dbHelper","Create Table acctitem ok");
	        }catch(Exception e){
	        	Log.v("dbHelper","Create Table acctitem err,table exists.");
	        }
	    }
	
	 public boolean addAccount(int acctid,int fee,int userid,String date,String time,String text){
	    	String sql="";
	    	try{
	    		sql="insert into account values(null,"+acctid+","+fee+","+userid+",'"+date+"','"+time+"','"+text+"')";
		        db.execSQL(sql);
		        
		        Log.v("dbHelper","insert Table account ok");
		        return true;
		        
	        }catch(Exception e){
	        	Log.v("dbHelper","insert Table bills err="+sql);
	        	return false;
	        }
	    }
	 
	 
	 public boolean addExpense(int acctid,int fee,int userid,String date,String time,String text){
	    	String sql="";
	    	try{
	    		sql="insert into bills values(null,"+acctid+","+fee+","+userid+",'"+date+"','"+time+"','"+text+"')";
		        db.execSQL(sql);
		        
		        Log.v("dbHelper","insert Table bills ok");
		        return true;
		        
	        }catch(Exception e){
	        	Log.v("dbHelper","insert Table bills err="+sql);
	        	return false;
	        }
	    }
	

}
