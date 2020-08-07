import { Component, OnInit, Input, Output, EventEmitter, OnChanges, SimpleChanges, SimpleChange } from '@angular/core';
import { AppUser } from './app-user';
import { AppUserAuth } from './app-user-auth';
import { SecurityService } from './security.service';
import { SharedService } from '../../shared.service';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {

 
  user: AppUser = new AppUser();
  securityObject = new AppUserAuth;
  tryLog: boolean = false;

   /*
  //déclaration si première connexion
  @Input() securityObject: AppUserAuth

  @Output() logUser: EventEmitter<AppUserAuth> = new EventEmitter<AppUserAuth>();
  */
  returnUrl: string;

  constructor(private _securityService: SecurityService,
    private route: ActivatedRoute,
    private router: Router) {

      /*
    this._securityService.messageSecurity.subscribe((message: AppUserAuth) => {
      this.securityObject = message;
    });

    if (this.securityObject == null){
      this.securityObject = new AppUserAuth
    }    
    */  
  }

  ngOnInit() {
    this.securityObject.isAuthenticated = false;
    this.returnUrl =
      this.route.snapshot
        .queryParamMap.get('returnUrl');
  }  

  login() {
    this._securityService.login(this.user)
      .subscribe(resp => {
        this.securityObject = resp;
        if (this.returnUrl) {
          this.router
            .navigateByUrl(this.returnUrl);
        }
        else{
          this.router
            .navigateByUrl('');
        }
      }, () => {        
        this.securityObject = new AppUserAuth();
        this.tryLog = true;
      });      
  }

}
