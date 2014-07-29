package co.nz.app.modules.login.fragments;

import co.nz.app.R;
import android.os.Bundle;
import android.support.v4.app.Fragment;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.view.View.OnClickListener;
import android.widget.Button;

public class UnlockScreenFragment extends Fragment {
	
	private View rootView = null;
	private Button MainMenu = null;
	
	
	public UnlockScreenFragment ( )
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
	        rootView = inflater.inflate(R.layout.fragment_unlockscreen, container, false);

	        InitialView( );
	        
	        
	        return rootView;
	    }
	  
	  
	  // Initial the GUI Views and click listener 
	  void InitialView( )
	  {
		  
		  MainMenu = (Button)rootView.findViewById(R.id.button_MainMenu);
	       
	       MainMenu.setOnClickListener(
			          new OnClickListener()
			          {
						@Override
						public void onClick(View v) {
							
							
							//Replace the current fragment with a new fragment view 
					//		SignUpScreenFragment Newfragment = new SignUpScreenFragment ( );
							
							//getActivity().getSupportFragmentManager().beginTransaction()
						//	.
						//	 getActivity().getSupportFragmentManager().beginTransaction()
						//	 .replace(R.id.item_detail_container, Newfragment)
						//	 .commit();
							 
							 
				               
							 
							 
							
						}
			          }
			        );

		  
	  }

}
