package co.nz.app.modules.login.fragments;

import co.nz.app.R;
import android.os.Bundle;
import android.support.v4.app.Fragment;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.view.View.OnClickListener;
import android.widget.Button;

public class SignUpScreenFragment extends Fragment {
	
	private View rootView = null;
	private Button Finish = null;
	
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
	        rootView = inflater.inflate(R.layout.fragment_signup, container, false);

	        // Show the dummy content as text in a TextView.
	       // if (mItem != null) {
	          //  ((TextView) rootView.findViewById(R.id.item_detail)).setText(mItem.content);
	       // }

	        return rootView;
	    }
	  
	  
	  // Initial the GUI Views and click listener 
	  void InitialView( )
	  {
		  
		  Finish=(Button)rootView.findViewById(R.id.Button_Next);
	       
	       Finish.setOnClickListener(
			          new OnClickListener()
			          {
						@Override
						public void onClick(View v) {
							
							
							//Replace the current fragment with a new fragment view 
							LoginScreenFragment Newfragment = new LoginScreenFragment ( );
							
							//getActivity().getSupportFragmentManager().beginTransaction()
						//	.
							 getActivity().getSupportFragmentManager().beginTransaction()
							 .replace(R.id.flContainer, Newfragment)
							  .addToBackStack(null)
							 .commit();
							 
							 
				               
							 
							 
							
						}
			          }
			        );

		  
	  }
	 

}
