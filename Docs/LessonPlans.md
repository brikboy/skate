# Session 01
- Create ground and idle image using gimp
    + Learn about layers
    + Learn about image sizing
    + Learn about selection tool
    + Learn about exporting image

# Session 02
- Setup Unity Project
    + Learn about navigating the basic environment
- Get familiar with unity environment
 

# Session 03
- Create idle player animation in gimp
    + Learn about frames and creating different images
    + Learn to preview the animation in using playback
        * Add `replace` to the layer
    + Learn to export the layers as a sprite strip using `Fuse Layers`
- Implement idle player animation in unity

# Session 04 - Moving the Player
- Familiarize with the scripting system in unity
- Create a C# script name `PlayerController`
    + C# is a object oriented language
    + Is a programming language designed to communicate instructions to a machine, particularly a computer. Programming languages can be used to create programs to control the behavior of a machine or to express algorithms.
- This script will be responsible for moving the player around.
- Importing packages at the top of the page
    + It's giving our program access to those packages or code someone else has written for us.
- What is a class?
    + Think of it as an extensible template
    + Provides initial values for state (member variables)
    + Contains implementations of behaviors (member functions)
- What is a member variable ?
    + Add `float maxSpeed = 20f;`
    + A variable is a storage location
    + Describe putting something into a cup
    + It has a type, meaning that only certain kinds of values can be stored into it.  Some basic ones are:
        * Number, in our case a floating point number
        * String or text, a word or words in a paragraph
        * Boolean or true/false
    + We assign is a default value of 10
    + Add `bool facingRight = true;`
- What is a member function?
    + Change `Update` to `FixedUpdate`
    + A function is a subroutine or a sequence of program instructions that perform a specific task.
    + `FixedUpdate` is a function that the unity engine will call for every frame rendered on a fixed time line
- Lets move the character
    ```
        void FixedUpdate {
            float move = Input.GetAxis("Horizontal");
            rigidbody2D.velocity = new Vector2(move * maxSpeed, rigidbody2D.velocity.y);
        }
    ```
 
# Session 05 - Animate the Moving Player
- Create `run` state animation
    + Add parameter named `speed` in the animator control
    + Make a transition from `idle` to `run` when speed is > .01
    + Make another transition from `run` to `idle` when speed is < .01

# Session 06 - Flip the Character
- Create a new function to flip
    ```
        void Flip() {
            facingRight = !facingRight;
            Vector3 scale = transform.localScale;
            scale.x = scale.x * -1;
            transform.localScale = scale;
        }
    ```
- What is an conditional statement?
- Add flip to the update calls
```
if (move > 0 &&!facingRight) {
    Flip();
} else if (move < 0 && facingRight) {
    Flip();
}
```


