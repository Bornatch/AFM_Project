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
export class LoginComponent implements OnChanges {

  user: AppUser = new AppUser();
  isLog: boolean = false;

  //déclaration si première connexion
  @Input() securityObject: AppUserAuth

  @Output() logUser: EventEmitter<AppUserAuth> = new EventEmitter<AppUserAuth>();
  returnUrl: string;

  constructor(private _securityService: SecurityService,
    private route: ActivatedRoute,
    private router: Router) {

    this._securityService.messageSecurity.subscribe((message: AppUserAuth) => {
      this.securityObject = message;
    });

    if (this.securityObject == null){
      this.securityObject = new AppUserAuth
    }      
  }

  ngOnChanges(changes: SimpleChanges): void {
  }

  ngOnInit() {
    this.securityObject.isAuthenticated = false;
    this.returnUrl =
      this.route.snapshot
        .queryParamMap.get('returnUrl');
  }

  sendMessage(): void {
    this._securityService.messageSecurity.next(this.securityObject)
  }

  login() {
    this._securityService.login(this.user)
      .subscribe(resp => {
        this.securityObject = resp;
        if (this.returnUrl) {
          this.router
            .navigateByUrl(this.returnUrl);
        }
      }, () => {
        // Display error message
        this.securityObject = new AppUserAuth();
      });
  }

}
