using System;


class Category{
  private int id;
  private string name;
  public Category(int id, string name) {
    this.id = id;
    this.name = name;
  }
  public override string ToString(){ return $"[{this.id}] {this.name}"; }
}