package co.nz.app;


import android.os.Bundle;
import android.support.v4.app.FragmentActivity;
import android.view.Menu;
import android.view.MenuItem;

public class AuthActivity extends FragmentActivity {

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_auth);
		
      // Load the login page fragment into MainActivity layout
    
       Bundle arguments = new Bundle();
      // arguments.putString(ItemDetailFragment.ARG_ITEM_ID,
             //  getIntent().getStringExtra(ItemDetailFragment.ARG_ITEM_ID));
       LockScreenFragment fragment = new LockScreenFragment();
       fragment.setArguments(arguments);
       getSupportFragmentManager().beginTransaction()
               .add(R.id.frContainer, fragment)
               .commit();
		
	}

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.auth, menu);
		return true;
	}

	@Override
	public boolean onOptionsItemSelected(MenuItem item) {
		// Handle action bar item clicks here. The action bar will
		// automatically handle clicks on the Home/Up button, so long
		// as you specify a parent activity in AndroidManifest.xml.
		int id = item.getItemId();
		if (id == R.id.action_settings) {
			return true;
		}
		return super.onOptionsItemSelected(item);
	}
}
