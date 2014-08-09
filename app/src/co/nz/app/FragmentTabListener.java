package co.nz.app;

import android.app.Activity;
import android.os.Bundle;
import android.support.v4.app.Fragment;
import android.support.v4.app.FragmentActivity;
import android.support.v4.app.FragmentTransaction;
import android.support.v7.app.ActionBar.Tab;
import android.support.v7.app.ActionBar.TabListener;

public class FragmentTabListener<T extends Fragment> implements TabListener {
	
	private Fragment mFragment;
	private final Activity mActivity;
	private final String mTag;
	private final Class<T> mClass;
	
	public FragmentTabListener(Activity activity,String tag,Class<T> clz){
		mActivity=activity;
		mTag=tag;
		mClass=clz;
	}
	
	/*The following are each of the ActionBar.TabListener callbacks*/
	
	@Override
	public void onTabReselected(Tab tab, FragmentTransaction ft) {
		//User selected to the already selected tab. Usually do nothing.
	}

	@Override
	public void onTabSelected(Tab tab, FragmentTransaction ft) {
		//check if the fragment is already initialized
		if(mFragment==null){
			//If not, instantiate and add it to the activity
			mFragment=Fragment.instantiate(mActivity, mClass.getName());
			ft.add(android.R.id.content,mFragment,mTag);//android.R.is give you the root element of a view,without having to know its actual name/type/id
		}else{
			//If it exists, simply attach it in order to show it.
			ft.attach(mFragment);
		}
		
	}

	@Override
	public void onTabUnselected(Tab tab, FragmentTransaction ft) {
		if(mFragment!=null){
			//Detach the fragment, because another one is being attached
			ft.detach(mFragment);
		}
		
	}
	
	

}
