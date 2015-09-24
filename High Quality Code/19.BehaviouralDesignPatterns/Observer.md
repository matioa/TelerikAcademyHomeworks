# Observer Design Pattern

### Important Points
 - Subject provides interface for observers to register and unregister themselves with the subject.  
 - Subject knows who its subscribers are. 
 - Multiple observers can subscribe for notifications. 
 - Subject publishes the notifications. 
 - Subject just sends the notification saying the state has changed. It does not pass any state information. 
 - Once the notification is received from subject, observers call the subject and get data that is changed. 
 - 
 The above last two points are not strictly followed in observer design pattern implementation. Along with the notification, state is also passed in some implementation so that the observer need not query back to know the status. It is better not to do this way.

### UML

![Obesrver UML](http://www.evietonline.com/wp-content/uploads/2015/09/observer-pattern-nlug6pdb.png)

### Scenario for Observer Pattern Usage

 - When multiple objects depend on state of one object and all these multiple objects should be in sync with the state of this one object then observer design pattern is the right choice to apply.
 - Consider an excel sheet, data is shown to the user in different views. Generally data is is shown in grid cells and as required different graphs, charts can be created for same data. Underlying data is same and when that data (subject) state changes all the different view are updated. 

### Example
Let us take a blog and subscriber example for observer design pattern sample implementation. Assume that there is a blog and users register to that blog for update. When a new article is posted in the blog, it will send update to the registered users saying a new article is posted. Then the user will access the blog and read the new article posted. In this example, blog is the subject and user is the observer.

![Example UML](http://javapapers.com/wp-content/uploads/2013/03/Example-Observer-Design-Pattern.png)
