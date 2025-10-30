# Virtual Reality Therapy System for Alzheimer’s Disease

# Overview
The Virtual Reality Therapy System is an immersive and interactive VR experience designed to slow the progression of Alzheimer’s disease by recreating home-like environments that stimulate cognitive and emotional responses in patients.
Built using Unity and C#, the system engages users in familiar daily activities and memory-based interactions with a virtual caregiver, replicating real-life support and companionship.

Inside the simulation, patients are placed in a home environment where they can move, touch, and interact with various objects — mimicking their daily routines in a safe, controlled virtual space.

Examples of these activities include:
Washing and organizing dishes to train memory, coordination, and procedural recall.
Drawing the time on a clock by dragging the clock hands — similar to cognitive assessment tests, but designed as a natural in-game task.
Interacting with the caregiver avatar, whose appearance and voice resemble the real caregiver, enhancing emotional familiarity and comfort.
Conversing about personal memories with the caregiver, reinforcing long-term memory recall and reducing cognitive decline.

This system combines neuroscience, virtual reality, and emotional design to help patients maintain mental activity, improve engagement, and promote a sense of independence and connection.

# Features
Immersive Home Environment – A realistic and comforting VR setting replicating daily household activities.
Personalized Caregiver Avatar – Uses Avaturn SDK to mirror the real caregiver’s voice, look, and communication patterns.
Cognitive Activity Simulations – Tasks such as dishwashing, arranging utensils, or adjusting a clock to the correct time.
Voice Interaction – The caregiver communicates naturally, referencing the patient’s past memories to encourage recall.
Touch & Drag Interactions – Users interact with virtual objects using hand-tracking and controller-based gestures.
Progress Tracking – Integrated cognitive performance analysis to monitor patient improvement over time.
Therapeutic Focus – Designed to reduce anxiety, improve focus, and foster emotional connection through multisensory engagement.

# Technical Implementation
Game Engine:	Unity
Language:	C#
VR Platform:	Meta Quest / OpenXR
3D Modeling & Animation:	Blender, Unity Asset Store resources
Avatars:	Avaturn SDK for caregiver and patient personalization
Cognitive Modules:	Dishwashing simulation, clock-drawing test, caregiver dialogue
Interaction Framework:	Unity XR Interaction Toolkit
Camera System:	Cinemachine
Audio System:	3D spatial sound synchronized with caregiver voice lines

# Folder Structure
https://drive.google.com/drive/folders/1_x4qw7uB1FH8cW89Q3NIiwBpthrgWFIj?usp=sharing
│
├── Assets/                # Game scenes, models, scripts, textures, and audio
├── Packages/              # Unity package dependencies
├── ProjectSettings/       # Unity build and configuration settings

# Research Context
This project is part of an interdisciplinary neuroscience study exploring how multisensory VR environments can stimulate cognitive and emotional functions in Alzheimer’s patients.
The design draws on clinical cognitive therapy principles, integrating them into an interactive, game-like format that patients can use independently or with caregiver supervision.

Through the combination of environmental familiarity, motor interaction, and personalized caregiver communication, the system aims to:
- Rebuild neural pathways related to memory and routine.
- Reduce emotional isolation and cognitive stress.
- Strengthen neuroplasticity through active sensory engagement.

# Future Development
Integration of haptic feedback for realistic touch sensations.
AI-driven caregiver responses for emotional, adaptive conversations.
Connection with biometric sensors to monitor heart rate and stress.
Companion mobile app for caregivers to adjust activities and track progress.
Optimization for low-cost VR hardware to ensure accessibility.

# Installation

1. Clone this repository:
git clone https://github.com/sama-muhammed/VR-ISEF.git

2. Open the project in Unity Hub (recommended version: Unity 2022 or later).
  
3. Make sure the following Unity packages are installed:
XR Interaction Toolkit
OpenXR Plugin
Cinemachine
Avaturn SDK (import manually if needed)

4. Connect your VR headset (Meta Quest or compatible) and press Play to run the simulation.

# Resources & References
- Unity XR Interaction Toolkit – Core interaction framework
- Avaturn SDK – Customizable avatars
- Unity Asset Store – 3D models and textures
- Blender – For custom object and environment modeling
- Research Literature:
1. “Virtual Reality in Cognitive Rehabilitation of Alzheimer’s Disease” – Frontiers in Aging Neuroscience
2.“Neuroplasticity Through Immersive Virtual Reality Training” – Nature Human Behavior 
