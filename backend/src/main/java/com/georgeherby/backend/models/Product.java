package com.georgeherby.backend.models;

import com.fasterxml.jackson.annotation.JsonProperty;
import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.NonNull;
import lombok.Setter;

@NoArgsConstructor
@AllArgsConstructor
@Getter
@Setter
public class Product {

  @JsonProperty("itemName")
  @NonNull
  private String itemName;

  @JsonProperty("price")
  @NonNull
  private int price;

}
