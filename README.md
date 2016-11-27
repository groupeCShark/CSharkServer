# CShark ptiChat

Notre code source a �t� �crit en **C#** et d�velopp� sous *Visual Studio 2015*.

### Architecture

Le projet est constitu� de 3 sous-projets :
- **CSharkLibrary** qui est une librairie contenant les interfaces et classes communes au client et au serveur
- **CSharkClient** qui est le code *WPF* impl�mentant la partie cliente
- **CSharkServer** qui impl�mente la partie serveur en *WCF*

### Liens

- CSharkLibrary : https://github.com/groupeCShark/CSharkLibrary
- CSharkClient : https://github.com/groupeCShark/Client
- CSharkServer : https://github.com/groupeCShark/CSharkServer

### Compilation

Pour compiler le serveur et le client, il est n�cessaire d'inclure la librairie commune CSharkLibrary :

1. `File -> Add -> Existing Project`
2. S�lectionner le fichier .csproj de la libraire CSharkLibrary
3. Dans le panneau Solution Explorer � droite, `Clic droit -> Add references -> Projects -> Solution`
4. Cocher CSharkLibrary

NB : Il est possible qu'il soit n�cessaire de supprimer une r�f�rence � *CSharkLibrary* d�j� existante.

Ensuite, un clic sur le bouton *Start* devrait lancer la compilation.

### Run

Une fois le serveur et le client compil�s, il faut se rendre de le r�pertoire bin/Debug/ des projets pour trouver les ex�cutables.

1. Lancer le fichier **CSharkServer.exe**. Une console Windows devrait alors se lancer.

![CSharkServer Start](/images/CSharkServerStart.png?raw=true "CSharkServer Start")

2. Lancer autant de clients **CSharkClient.exe** que n�cessaire. Une fen�tre de *chat* devrait alors se lancer et la connexion au serveur devrait r�ussir.

![CSharkClient Start](/images/CSharkClientStart.png?raw=true "CSharkClient Start")


### Utilisation

##### Client

L'interface cliente est plut�t simple et intuitive.

L'envoie de fichiers se fait en cliquant sur le bouton File. Les fichiers envoy�s se retrouvent dans un r�pertoire /download dans le dossier de lancement de l'application.

Le pseudo par d�faut est "Anonymous". Il peut �tre chang� dans le fichier config.xml. Un red�marrage est alors n�cessaire pour prendre en compte les modifications. La commande `!username <Votre Nouveau Pseudo>` permet �galement de modifier le pseudo tout en utilisant l'application.


##### Serveur

L'utilisation du serveur reste �galement tr�s simple. Une fois lanc�, la commande `help` affiche l'ensemble des commandes support�s.

Par exemple, la commande `userlist` affiche la liste des utilisateurs actuellement connect�s.


### R�f�rences

- L'article [A WCF Tutorial](http://blog.the-blair.com/2010/04/02/wcf-tutorial.html) par Blair Kitchen nous a beaucoup aid� � �crire la partie WCF du projet.
- La section [Cr�er une application Windows avec WPF](https://openclassrooms.com/courses/les-differents-types-d-applications-pouvant-etre-developpees-avec-le-c) du tutoriel d'OpenClassroom par Nicolas Hilaire nous a permis de nous familiariser avec WPF.
