 
 
Water Control (Beta):
	1.	Drag the ‘Water.cs’ onto an object which you would like to add water behaviour to
	2.	Adjust the settings according to your preference:
		•	Pressure (Float) – Force at which Rigidbodies will be pushed to surface
		•	Water Drag (Float) – Drag applied to submerged objects
		•	Size (Vector 3) – Size of the box which represents water
	3.	Play the scene and observe as all submerged Rigidbodies float to the surface of the water object
Requires: Null – Creates box collider upon run.
Notes: Water script is currently in beta and requires a bit of tampering with the settings to create a realistic effect.
 
Wind Control:
	1.	Drag the ‘Wind.cs’ onto an object which you would like to add wind behaviour to
	2.	Adjust the settings according to your preference:
		•	Lift (Float) – Force at which Rigidbodies will be pushed in direction
	3.	Rotate the Wind object in the direction you would like the wind to be applied (As shown by gizmo)
	4.	Play the scene and observe as all Rigidbody objects within range get pushed towards the direction.
Requires: Collider (Any type) – this will be used as trigger. 

Bounce Plate Control:
	1.	Drag the ‘BouncePlate.cs’ onto an object which you would like to add bounce behaviour to
	2.	Adjust the settings according to your preference:
	•	Bounce (Float) – Force at which Rigidbodies will bounce
	3.	Play the scene and observe as all Rigidbody objects bounce when they touch the bounce plate
Requires: Collider (Any type) – this will be used as trigger. 
Notes: This is a simple script I thought I would through in with the package. 
 
Zero Gravity Zone Control:
	1.	Drag the ‘ZeroGravity.cs’ onto an object which you would like to add zero gravity behaviour to
	2.	Play the scene and observe as all Rigidbody objects inside of collider become unaffected by gravity
Requires: Collider (Any type) – this will be used as trigger. 
Notes: Simple utility script which switches the ‘Use Gravity’ Boolean in the rigidbidy off/on.

That wraps up the technical stuff. Please get in touch if you need any assistance getting any of these scripts up and running. 

I really appreciate the support. Any suggestions for improvements/additional features are always welcomed.

Thanks.



