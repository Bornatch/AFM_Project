import { Component, OnInit } from '@angular/core';
import { SecurityService } from '../security/security.service';
import { AppUserAuth } from '../security/app-user-auth';

@Component({
  selector: 'app-sidebar',
  templateUrl: './sidebar.component.html',
  styleUrls: ['./sidebar.component.scss']
})
export class SidebarComponent implements OnInit {

  securityObject: AppUserAuth;
  isLog: boolean;

  constructor(private _sharedService: SecurityService) { 
    this._sharedService.messageSecurity.subscribe((message: AppUserAuth)=>{
      this.securityObject = message;      
      this.setIsLog();
    });
  }

  ngOnInit() {
  }

  setIsLog() {   
    if (this.securityObject == null) {     
      this.isLog = this.securityObject.isAuthenticated
    }
    else {            
      this.isLog = this.securityObject.isAuthenticated
    }
  }

}
