import { Component, OnInit, OnChanges, SimpleChanges } from '@angular/core';
import { SecurityService } from '../../shared/components/security/security.service';
import { AppUserAuth } from '../../shared/components/security/app-user-auth';

@Component({
  selector: 'app-default',
  templateUrl: './default.component.html',
  styleUrls: ['./default.component.scss']
})
export class DefaultComponent implements OnChanges {

  //login
  securityObject: AppUserAuth ;
  isLog:boolean = false;
  //sideBar
  sideBarOpen = false;

  constructor
    (private securityService: SecurityService) {
    this.securityObject =
      securityService.securityObject;
  }
  ngOnChanges(changes: SimpleChanges): void {
    console.log(this.securityObject)
  }

  ngOnInit() {
    
   }

  logout(): void {
    this.securityService.logout();
  }

  setIsLog() {
     if(this.securityObject == null){
       this.isLog = false
     }    
    else{
      this.isLog = this.securityObject.isAuthenticated  }
    }

  setSecurityObject(){
    this.securityObject;
    console.log(this.securityObject)
  }


  sideBarToggler() {
    this.sideBarOpen = !this.sideBarOpen;
  }
}
