import { Component } from '@angular/core';
import { ContactService } from '../../service/contact';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-contact',
  imports: [CommonModule,FormsModule],
  templateUrl: './contact.html',
  styleUrl: './contact.css',
})
export class Contact {
   profileUrl = 'assets/tavrej.jpg';
   contact = {
    name: '',
    email: '',
    subject: '',
    message: ''
  };

  successMessage = '';

  constructor(private contactService: ContactService) {}

  submitForm() {
    this.contactService.sendMessage(this.contact).subscribe({
      next: (res) => {
        this.successMessage = res.message;

        this.contact = {
          name: '',
          email: '',
          subject: '',
          message: ''
        };
      },
      error: (err) => {
        console.error(err);
      }
    });
  }
}


