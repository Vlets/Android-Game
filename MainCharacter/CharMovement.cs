using UnityEngine;
using System.Collections;

public class CharMovement : MonoBehaviour {

	// ----------------------
	// Controller Variable 
	// ----------------------
	
	public	TouchController	ctrl;
	
	
	// ----------------------
	// Constants
	// ----------------------
	
	public const int STICK_WALK	= 0;
	public const int ZONE_ACTION	= 0;
	public const int ZONE_SCREEN	= 1;
	
	
	// ----------------------
	// Update()
	// ----------------------
	
	void Update()
	{
		if (this.ctrl != null)
		{
			// ----------------------
			// Stick and Zone Variables
			// ----------------------
			
			TouchStick	walkStick	= this.ctrl.GetStick(STICK_WALK);
			TouchZone	actionZone	= this.ctrl.GetZone(ZONE_ACTION);
			TouchZone	screenZone	= this.ctrl.GetZone(ZONE_SCREEN);
			
			
			// ----------------------
			// Input Handling Code
			// ----------------------
			
			// ----------------
			// Stick 'Walk'...
			// ----------------
			
			if (walkStick.Pressed())
			{
				Vector2	walkVec				= walkStick.GetVec();
				float	walkTilt			= walkStick.GetTilt();
				float	walkAngle			= walkStick.GetAngle();
				TouchStick.StickDir	walkDir	= walkStick.GetDigitalDir(true);
				Vector3	walkWorldVec		= walkStick.GetVec3d(false, 0);
				
				// Your code here.
			}
			
			// ----------------
			// Zone 'Action'...
			// ----------------
			
			if (actionZone.JustUniPressed())
			{
				Vector2 actionPressStartPos	= actionZone.GetUniStartPos(TouchCoordSys.SCREEN_PX);
				
			}
			
			// Uni-touch pressed...
			
			if (actionZone.UniPressed())
			{
				float	actionUniDur				= actionZone.GetMultiTouchDuration();
				Vector2	actionUniPos				= actionZone.GetMultiPos();
				Vector2	actionUniDragDelta		= actionZone.GetMultiDragDelta();
				Vector2	actionUniRawDrawDelta	= actionZone.GetMultiDragDelta(true);
				
				
			}
			
			
			// Uni-Touch Just Released
			
			if (actionZone.JustUniReleased())
			{
				Vector2	actionUniRelStartPos	= actionZone.GetReleasedUniStartPos();
				Vector2	actionUniRelEndPos	= actionZone.GetReleasedUniEndPos();
				int 	actionUniRelStartBox	= TouchZone.GetBoxPortion(2, 2, actionZone.GetReleasedUniStartPos(TouchCoordSys.SCREEN_NORMALIZED)); 
				int 	actionUniRelEndBox	= TouchZone.GetBoxPortion(2, 2, actionZone.GetReleasedUniEndPos(TouchCoordSys.SCREEN_NORMALIZED)); 
				
				Vector2	actionUniRelDragVel	= actionZone.GetReleasedUniDragVel();
				Vector2 actionUniRelDragVec	= actionZone.GetReleasedUniDragVec();
				
				
			}
			
			
			// ----------------
			// Zone 'SCREEN'...
			// ----------------
			
			if (screenZone.JustMultiPressed())
			{
				Vector2 screenMultiPressStartPos	= screenZone.GetMultiStartPos(TouchCoordSys.SCREEN_PX);
				
			}
			
			if (screenZone.JustUniPressed())
			{
				Vector2 screenPressStartPos	= screenZone.GetUniStartPos(TouchCoordSys.SCREEN_PX);
				
			}
			
			// Multi-Pressed...
			
			if (screenZone.MultiPressed())
			{
				float	screenMultiDur			= screenZone.GetMultiTouchDuration();
				Vector2	screenMultiPos			= screenZone.GetMultiPos();
				Vector2	screenMultiDragDelta		= screenZone.GetMultiDragDelta();
				Vector2	screenMultiRawDrawDelta	= screenZone.GetMultiDragDelta(true);
				
				
				// Multi-touch drag...
				
				if (screenZone.JustMultiDragged())
				{
				}
				
				if (screenZone.MultiDragged())
				{
				}
				
				// Just Twisted...
				
				if (screenZone.JustTwisted())
				{
				}
				
				// Twisted...
				
				if (screenZone.Twisted())
				{
					float	screenTwistDelta	= screenZone.GetTwistDelta();
					float	screenTwistTotal	= screenZone.GetTotalTwist();
					
				}
				
				// Just Pinched...
				
				if (screenZone.JustPinched())
				{
				}
				
				// Pinched...
				
				if (screenZone.Pinched())
				{
					float	screenPinchRelScale	= screenZone.GetPinchRelativeScale();
					float	screenPinchAbsScale	= screenZone.GetPinchScale();
					float	screenFingerDist		= screenZone.GetPinchDist();
					
				}
				
			}
			
			// Uni-touch pressed...
			
			if (screenZone.UniPressed())
			{
				float	screenUniDur				= screenZone.GetMultiTouchDuration();
				Vector2	screenUniPos				= screenZone.GetMultiPos();
				Vector2	screenUniDragDelta		= screenZone.GetMultiDragDelta();
				Vector2	screenUniRawDrawDelta	= screenZone.GetMultiDragDelta(true);
				
				
				// Just Uni-touch dragged...
				
				if (screenZone.JustUniDragged())
				{
				}
				
				// Uni-Touch drag...
				
				if (screenZone.UniDragged())
				{
				}
			}
			
			
			// Multi-Touch Just Released
			
			if (screenZone.JustMultiReleased())
			{
				Vector2	screenMultiRelStartPos	= screenZone.GetReleasedMultiStartPos();
				Vector2	screenMultiRelEndPos		= screenZone.GetReleasedMultiEndPos();
				int 	screenMultiRelStartBox	= TouchZone.GetBoxPortion(2, 2, screenZone.GetReleasedMultiStartPos(TouchCoordSys.SCREEN_NORMALIZED)); 
				int 	screenMultiRelEndBox		= TouchZone.GetBoxPortion(2, 2, screenZone.GetReleasedMultiEndPos(TouchCoordSys.SCREEN_NORMALIZED)); 
				
				Vector2	screenMultiRelDragVel	= screenZone.GetReleasedMultiDragVel();
				Vector2 screenMultiRelDragVec	= screenZone.GetReleasedMultiDragVec();
				
				// Released multi-touch was dragged...
				
				if (screenZone.ReleasedMultiDragged())
				{
				}
				
				// Released multi-touch was twisted...
				
				if (screenZone.ReleasedTwisted())
				{
					float	screenRelTwistAngle	= screenZone.GetReleasedTwistAngle();
					float	screenRelTwistVel		= screenZone.GetReleasedTwistVel();
					
				}
				
				// Released multi-touch was pinched...
				
				if (screenZone.ReleasedPinched())
				{
					float	screenRelPinchStartDist	= screenZone.GetReleasedPinchStartDist();
					float	screenRelPinchEndDist		= screenZone.GetReleasedPinchEndDist();
					float	screenRelPinchScale		= screenZone.GetReleasedPinchScale();
					
				}
				
			}
			
			
			// Uni-Touch Just Released
			
			if (screenZone.JustUniReleased())
			{
				Vector2	screenUniRelStartPos	= screenZone.GetReleasedUniStartPos();
				Vector2	screenUniRelEndPos	= screenZone.GetReleasedUniEndPos();
				int 	screenUniRelStartBox	= TouchZone.GetBoxPortion(2, 2, screenZone.GetReleasedUniStartPos(TouchCoordSys.SCREEN_NORMALIZED)); 
				int 	screenUniRelEndBox	= TouchZone.GetBoxPortion(2, 2, screenZone.GetReleasedUniEndPos(TouchCoordSys.SCREEN_NORMALIZED)); 
				
				Vector2	screenUniRelDragVel	= screenZone.GetReleasedUniDragVel();
				Vector2 screenUniRelDragVec	= screenZone.GetReleasedUniDragVec();
				
				
				// Released uni-touch was dragged...
				
				if (screenZone.ReleasedUniDragged())
				{
				}
				
			}
			
			
			// Double multi-finger tap...
			
			if (screenZone.JustMultiDoubleTapped())
			{		
				Vector2	screenMultiDblTapPos = screenZone.GetMultiTapPos();
				
			}
			else 
				
				// Simple multi-finger tap...
				
				if (screenZone.JustMultiTapped())
			{
				Vector2	screenMultiTapPos	= screenZone.GetMultiTapPos();
				
			}	
			else 
				
				// Double one-finger tap...
				
				if (screenZone.JustDoubleTapped())
			{		
				Vector2	screenDblTapPos = screenZone.GetTapPos();
				
			}
			else 
				
				// Simple one-finger tap...
				
				if (screenZone.JustTapped())
			{
				Vector2	screenTapPos	= screenZone.GetTapPos();
				
			}
			
			
			
			
			
		}
	}
	
	
	

}
