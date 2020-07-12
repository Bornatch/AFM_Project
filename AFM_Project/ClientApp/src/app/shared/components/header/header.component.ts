import { Component, OnInit, Output, EventEmitter, OnChanges, SimpleChanges, Input } from '@angular/core';
import { AppUserAuth } from '../security/app-user-auth';
import { SecurityService } from '../security/security.service';


@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss']
})
export class HeaderComponent implements OnChanges {


  securityObject: AppUserAuth;
  @Output() toggleSideBarForMe: EventEmitter<any> = new EventEmitter();
  @Input() LoginComponent
  isLog: boolean;

  constructor(private _securityService: SecurityService) { 
    this._securityService.messageSecurity.subscribe((message: AppUserAuth)=>{
      this.securityObject = message;
      this.setIsLog();
    });
  }

  ngOnInit() {
  }

  ngOnChanges(changes: SimpleChanges) {
  }

  setIsLog() {   
    if (this.securityObject == null) {     
      this.isLog = this.securityObject.isAuthenticated
    }
    else {            
      this.isLog = this.securityObject.isAuthenticated
    }
  }

  toggleSideBar() {
    this.toggleSideBarForMe.emit();
    setTimeout(() => {
      window.dispatchEvent(
        new Event('resize')
      );
    }, 300);
  }

  logout(): void {
    this._securityService.logout();
  }
  
  



}
