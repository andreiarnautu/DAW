import { Component, OnInit } from '@angular/core';
import { BooksService } from 'src/app/shared/books.service';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-books-form',
  templateUrl: './books-form.component.html',
  styleUrls: ['./books-form.component.css']
})
export class BooksFormComponent implements OnInit {

  constructor(public service: BooksService) { }

  ngOnInit(): void {
  }

  onSubmit(form: NgForm) {
    this.service.postBook().subscribe(
      res => {

      },
      err => { console.log(err); }
    );
  }

}
