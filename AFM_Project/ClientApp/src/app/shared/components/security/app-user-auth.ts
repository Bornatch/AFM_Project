//Definition des accès 
//TODO ajouter la table [Seilern].[dbo].[Customer_right] dans table [Seilern].[dbo].[Customer] la FK Id_right 
export class AppUserAuth {
    webUserName: string = "";
    bearerToken: string = "";
    isAuthenticated: boolean = false;
    isAdmin: boolean = false;  
    isUser : boolean = false;
  }
     