package co.nz.app.modules.login.fragments;

import co.nz.app.R;
import android.os.Bundle;
import android.support.v4.app.Fragment;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;

public class SignUpScreenFragment extends Fragment {
	
	public SignUpScreenFragment ( )
	{
		
		
		
	}
	
	
	 @Override
	 public void onCreate(Bundle savedInstanceState) 
	 
	    {
	        super.onCreate(savedInstanceState);

	      //  if (getArguments().containsKey(ARG_ITEM_ID)) {
	            // Load the dummy content specified by the fragment
	            // arguments. In a real-world scenario, use a Loader
	            // to load content from a content provider.
	        //    mItem = DummyContent.ITEM_MAP.get(getArguments().getString(ARG_ITEM_ID));
	     //   }	        
	        
	        
	    }
	 
	 
	  @Override
	    public View onCreateView(LayoutInflater inflater, ViewGroup container,
	            Bundle savedInstanceState) 
	    {
	        View rootView = inflater.inflate(R.layout.fragment_signup, container, false);

	        // Show the dummy content as text in a TextView.
	       // if (mItem != null) {
	          //  ((TextView) rootView.findViewById(R.id.item_detail)).setText(mItem.content);
	       // }

	        return rootView;
	    }
	 

}
