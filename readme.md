## Purpose
The purpose of this sample project is to analyze clean architecture. I want to understand how the dependancies work and why this pattern makes a project framework dependent and more agile.

The project's end goal is to save an web article's text and allow a user to persist highlights and take notes (pretty much pocket).


## Get Started
Create your key ssh-keygen -t rsa -b 4096 -C "your_email@example.com"


ssh-add yourkey for windows you might need to start up the ssh-agent with
the eval $(ssh-agent -s) command beforehand. If this seems continual then
take a look at https://stackoverflow.com/questions/18404272/running-ssh-agent-when-starting-git-bash-on-windows

Take your public key and add it to the ssh keys in your gitlab profile.

## The Architecture

The Core
1. The domain layer holds entities, enums, exceptions, types and logic specific to the domain. 
2. The application layer holds all application logic. It is dependent on the domain layer, but has no dependencies on any other layer or project.

Infrastrucure
1. The database layer contains classes for accessing the database. The main classes should be based on an interface defined within the application layer.
