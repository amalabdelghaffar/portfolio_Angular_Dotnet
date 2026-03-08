import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

export interface Profile {
  id: number; fullName: string; title: string; email: string;
  phone: string; location: string; about: string;
  githubUrl: string; linkedinUrl: string; avatarUrl: string;
}
export interface Experience {
  id: number; title: string; company: string; location: string;
  startDate: string; endDate: string; description: string;
  technologies: string; isCurrent: boolean; order: number;
}
export interface Education {
  id: number; degree: string; institution: string; location: string;
  startDate: string; endDate: string; description: string; order: number;
}
export interface Skill {
  id: number; name: string; category: string; level: number; icon: string;
}
export interface Certification {
  id: number; name: string; issuer: string; date: string; description: string;
}
export interface Language {
  id: number; name: string; level: number; proficiency: string;
}
export interface CommunityActivity {
  id: number; role: string; organization: string;
  startDate: string; endDate: string; order: number;
}

@Injectable({ providedIn: 'root' })
export class PortfolioService {
  private baseUrl = 'http://localhost:5050/api';

  constructor(private http: HttpClient) {}

  getProfile(): Observable<Profile> { return this.http.get<Profile>(`${this.baseUrl}/profile`); }
  getExperiences(): Observable<Experience[]> { return this.http.get<Experience[]>(`${this.baseUrl}/experiences`); }
  getEducations(): Observable<Education[]> { return this.http.get<Education[]>(`${this.baseUrl}/educations`); }
  getSkills(): Observable<Skill[]> { return this.http.get<Skill[]>(`${this.baseUrl}/skills`); }
  getCertifications(): Observable<Certification[]> { return this.http.get<Certification[]>(`${this.baseUrl}/certifications`); }
  getLanguages(): Observable<Language[]> { return this.http.get<Language[]>(`${this.baseUrl}/languages`); }
  getCommunity(): Observable<CommunityActivity[]> { return this.http.get<CommunityActivity[]>(`${this.baseUrl}/community`); }
}
