package co.nz.app;
import android.support.v7.app.ActionBar;
import android.support.v7.app.ActionBar.Tab;



import co.nz.app.modules.login.fragments.LoginScreenFragment;
import android.support.v4.app.FragmentActivity;
import android.support.v7.app.ActionBarActivity;

import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;


public class MainActivity extends ActionBarActivity{

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        setupTabs();
        
        
        
        
        
//       // Load the login page fragment into MainActivity layout
//     
//        Bundle arguments = new Bundle();
//       // arguments.putString(ItemDetailFragment.ARG_ITEM_ID,
//              //  getIntent().getStringExtra(ItemDetailFragment.ARG_ITEM_ID));
//        LoginScreenFragment fragment = new LoginScreenFragment();
//        fragment.setArguments(arguments);
//        getSupportFragmentManager().beginTransaction()
//                .add(R.id.item_detail_container, fragment)
//                .commit();
    }
    
    private void setupTabs(){
    	ActionBar actionBar=getSupportActionBar();
        actionBar.setDisplayHomeAsUpEnabled(true);
        actionBar.setNavigationMode(ActionBar.NAVIGATION_MODE_TABS);
        actionBar.setDisplayShowTitleEnabled(true);
        
        Tab tab1=actionBar
        		.newTab()
        		.setText("Dashboard")
//        		.setIcon(R.drawable.ic_launcher)
        		.setTag("DashboardFragment")
        		.setTabListener(
        				new FragmentTabListener<DashboardFragment>(this,"Dashboard",DashboardFragment.class)
        				);
        actionBar.addTab(tab1);
        actionBar.selectTab(tab1);
        
        Tab tab2=actionBar
        		.newTab()
        		.setText("Expense")
//        		.setIcon(R.drawable.ic_launcher)
        		.setTag("ExpenseFragment")
        		.setTabListener(
        				new FragmentTabListener<ExpenseFragment>(this,"Expense",ExpenseFragment.class)
        				);
        actionBar.addTab(tab2);
        
        Tab tab3=actionBar
        		.newTab()
        		.setText("Reminder")
//        		.setIcon(R.drawable.ic_launcher)
        		.setTag("ReminderFragment")
        		.setTabListener(
        				new FragmentTabListener<ReminderFragment>(this,"Reminder",ReminderFragment.class)
        				);
        actionBar.addTab(tab3);
        
    }


    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.main, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        // Handle action bar item clicks here. The action bar will
        // automatically handle clicks on the Home/Up button, so long
        // as you specify a parent activity in AndroidManifest.xml.
        int id = item.getItemId();
        switch(id){
        	case R.id.action_search:
        		//doSearch();
        		return true;
        	case R.id.action_new:
        		//doEdit();
        		return true;
        	case R.id.action_profile:
        		//doProfile();
        		return true;
        	case R.id.action_categories:
        		//doCategories();
        		return true;
        	case R.id.action_contacts:
        		//doContacts();
        		return true;
        	default:
        		return super.onOptionsItemSelected(item); 
        	
        }
     }
}



























