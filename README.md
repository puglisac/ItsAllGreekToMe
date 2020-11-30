# It's All Greek to Me

This is an exercise for the coursera course [Introduction to C# Programming and Unity](https://www.coursera.org/learn/introduction-programming-unity)

## Assignment Description

Imagine you've built a time machine so you can travel back in time to meet the Greeks (specifically, Pythagoras and Hipparchus) who have helped give us amazing theorems (Pythagorean Theorem) and branches of mathematics (Trigonometry) that directly help us in our game development! Luckily, you're bringing your computer along with you (and, of course, a power source of some kind) so you can show off your programming skills.

In this assignment, you'll calculate the distance between two points and the angle a game character would need to move in to go from the second point to the first point.

## Why do we care?

There are lots of times in game development where we need to know the distance between two points. For example, an NPC might determine which target to go after based on which one is closest to the NPC. What about angle? For the same example, the NPC needs to figure out how to move toward the selected target; having the angle lets us build the appropriate velocity vector for the NPC.

## The Pythagorean Theorem

The Pythagorean Theorem tells us how to calculate the length of the hypotenuse of a right triangle.

We know from the theorem that

c^2=a^2+b^2
 

so if we take the square root of a^2+b^2a, we'll get c, the length of the hypotenuse.

## Requirements

1. Calculate the delta x and delta y between the two points; the term delta is often used in science and engineering for the difference or change between two values. The subtraction order matters when you calculate the angle in a later step, so be sure to subtract the first point values from the second point values

2. Calculate the distance (as a **float**) between the two points using the Pythagorean Theorem. The distance we're calculating is just the length of the hypotenuse (c) where we calculated a (delta x) and b (delta y) in the previous step. You might want to explore the documentation for the \tt{Math}Math class to help with this calculation.

3. Calculate the angle (as a **float**) we'd have to move in to go from point 2 to point 1 (0 degrees is directly to the right). Be careful here; we're not trying to calculate any of the angles inside the triangle. Think of it this way: your character is at the first point, facing directly to the right. What angle would you need to rotate by to be facing the second point?

4. Print the distance and the angle.
 
## Installation
To install, follow these steps:

Via Downloading from GitHub:

Download this repository onto your machine by clicking the "Clone or Download" button or Fork the repo into your own Github account
Download and extract the zip file to a directory of your choice.  

Via command line:

`$ git clone https://github.com/puglisac/ItsAllGreekToMe.git`  

open ItsAllGreek.sln in [Visual Studio](https://visualstudio.microsoft.com/) and click Run to start.
